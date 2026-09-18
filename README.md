# MyProject - Overview & Architecture Guide

Hệ thống được phát triển trên nền tảng **ASP.NET Core MVC & jQuery** sử dụng **ABP Framework (ASP.NET Boilerplate)**.

---

## ⚡ Các Tính Năng Nổi Bật Của ABP Framework

ABP Framework cung cấp sẵn các hạ tầng mạnh mẽ giúp chuẩn hóa và tối ưu hóa quá trình phát triển ứng dụng:

1. **Dependency Injection (DI)**: Cung cấp hạ tầng DI tự động theo quy ước (Convention-based DI). Các Application Service, Repository được tự động đăng ký vào IoC Container (mặc định dạng Transient cho mỗi Request) giúp việc tiêm phụ thuộc (như `IRepository<Product, long>`) cực kỳ đơn giản.
2. **Repository Pattern**: Tự động tạo mặc định Repository cho mỗi Entity (ví dụ: `IRepository<Product, long>`) cung cấp sẵn các phương thức tương tác cơ bản như `FirstOrDefaultAsync`, `InsertAsync`, `DeleteAsync`, `GetAllIncludingAsync`.
3. **Authorization (Phân quyền)**: Phân quyền khai báo (Declarative Permission Check) bằng `[AbpAuthorize]` hoặc `[AbpMvcAuthorize]`. Tự động chặn truy cập nếu người dùng không đủ quyền hoặc chưa đăng nhập.
4. **Validation (Xác thực dữ liệu)**: Tự động kiểm tra tham số đầu vào `null`, validate dữ liệu tự động dựa trên Data Annotations (`[Required]`, `[StringLength]`,...) và các quy tắc custom. Nếu dữ liệu không hợp lệ, hệ thống tự ném `AbpValidationException` và xử lý thông báo về Client.
5. **Audit Logging (Nhật ký hệ thống)**: Tự động ghi lại nhật ký thao tác (User, IP address, Browser, Service, Method, tham số, thời gian thực thi) cho từng Request theo cấu hình.
6. **Unit Of Work (UOW)**: Mỗi phương thức trong Application Service mặc định được quản lý như một Unit of Work. ABP tự mở kết nối và khởi tạo Transaction. Nếu phương thức chạy thành công không có lỗi, Transaction tự động Commit và đóng kết nối. Mọi thay đổi thuộc tính trên Entity được tự động theo dõi và lưu trữ mà không cần gọi `_repository.Update(...)` thủ công.
7. **Exception Handling (Xử lý ngoại lệ)**: Bắt và xử lý ngoại lệ tự động toàn cục. Nếu có lỗi xảy ra, ABP tự động ghi Log và trả về phản hồi JSON chuẩn cho Client. Khi ném `UserFriendlyException`, thông báo lỗi nghiệp vụ sẽ được hiển thị trực tiếp cho người dùng.
8. **Logging (Ghi log)**: Tích hợp sẵn hạ tầng ghi log thông qua đối tượng `Logger` hoặc `ILogger<T>`, hỗ trợ Log4Net/Microsoft Logging dễ dàng cấu hình ghi ra File hoặc Console.
9. **Localization (Đa ngôn ngữ)**: Hỗ trợ đa ngôn ngữ thông qua phương thức `L("StringKey")`, tự động dịch thông điệp theo ngôn ngữ/vùng quốc gia (Culture) của người dùng hiện tại.
10. **Auto Mapping (Ánh xạ tự động)**: Tích hợp thư viện AutoMapper qua `IObjectMapper` (`ObjectMapper.Map(...)`) giúp chuyển đổi tự động các thuộc tính giữa Entity và DTO dựa theo quy ước đặt tên.
11. **Dynamic API Layer**: Tự động tạo ra các endpoint Web API từ các Application Service ở thời điểm runtime, cho phép Client gọi trực tiếp các phương thức AppService qua HTTP mà không cần viết Controller wrapper thủ công.
12. **Dynamic JavaScript AJAX Proxy**: Tự động sinh ra các hàm Proxy Javascript ở phía Client, giúp việc gọi các phương thức Application Service ở giao diện Web đơn giản như gọi hàm JavaScript thông thường.

---

## 📁 Cấu Trúc Source Code (`aspnet-core/src/`)

```text
aspnet-core/src/
│
├── 📁 MyProject.Core/                  <--- [Domain Layer: Chứa Entities, Enums & Business Rules]
│   ├── 📁 Authorization/
│   │   ├── 📁 Users/
│   │   │   └── User.cs                <-- Entity User (Quản lý người dùng)
│   │   └── 📁 Roles/
│   │       └── Role.cs                <-- Entity Role (Quản lý vai trò / phân quyền)
│   ├── 📁 MultiTenancy/
│   │   └── Tenant.cs                  <-- Entity Tenant (Hỗ trợ đa người thuê - Multi-tenancy)
│   ├── 📁 Products/                   <-- Entity & Enum của Sản Phẩm
│   │   ├── Product.cs                 <-- Entity Product (Thông tin sản phẩm)
│   │   ├── ProductImage.cs            <-- Entity ProductImage (Hình ảnh sản phẩm)
│   │   └── ProductStatus.cs           <-- Enum ProductStatus (Trạng thái sản phẩm)
│   ├── 📁 ProductCategories/
│   │   └── ProductCategory.cs         <-- Entity ProductCategory (Danh mục sản phẩm)
│   └── 📁 Localization/               <-- File XML chứa từ điển ngôn ngữ (Multilingual / i18n)
│
├── 📁 MyProject.EntityFrameworkCore/  <--- [Data Access Layer: Quản lý Database & ORM]
│   ├── 📁 EntityFrameworkCore/
│   │   ├── MyProjectDbContext.cs      <-- EF Core DbContext (Quản lý các DbSet / Tables trong Database)
│   │   └── 📁 Repositories/           <-- Custom Repositories (Xử lý truy vấn dữ liệu nâng cao)
│   └── 📁 Migrations/                 <-- Quản lý các phiên bản cấu trúc Database (EF Core Migrations)
│
├── 📁 MyProject.Application/          <--- [Application Layer: Chứa Business Logic & DTOs]
│   ├── 📁 Users/
│   │   ├── IUserAppService.cs         <-- Interface Service Người dùng
│   │   ├── UserAppService.cs          <-- Class thực thi Business Logic Người dùng
│   │   └── 📁 Dto/                    <-- Data Transfer Objects (Request/Response DTO cho User)
│   ├── 📁 Roles/                      <-- Service & DTO cho Role
│   ├── 📁 MultiTenancy/               <-- Service & DTO cho Tenant
│   └── 📁 Products/                   <-- Business Logic & DTO của Sản Phẩm
│       ├── IProductAppService.cs      <-- Interface định nghĩa nghiệp vụ Sản phẩm
│       ├── ProductAppService.cs       <-- Thực thi CRUD, Tìm kiếm & Phân trang Sản phẩm
│       └── 📁 Dto/
│           ├── ProductDto.cs          <-- DTO trả về thông tin Sản phẩm
│           ├── CreateProductDto.cs    <-- DTO nhận dữ liệu tạo mới Sản phẩm
│           ├── UpdateProductDto.cs    <-- DTO nhận dữ liệu cập nhật Sản phẩm
│           ├── ProductImageDto.cs     <-- DTO dữ liệu hình ảnh Sản phẩm
│           ├── PagedProductResultRequestDto.cs <-- DTO tham số phân trang & lọc dữ liệu
│           └── ProductMapProfile.cs   <-- Cấu hình Ánh xạ DTO với Entity (AutoMapper)
│
├── 📁 MyProject.Web.Mvc/              <--- [Presentation Layer: Web UI Controller, Models & Views]
│   ├── 📁 Controllers/                <-- MVC Controllers xử lý HTTP Requests
│   │   ├── UsersController.cs
│   │   ├── RolesController.cs
│   │   └── ProductsController.cs      <-- Controller xử lý giao diện Sản phẩm
│   ├── 📁 Models/                     <-- ViewModels truyền dữ liệu từ Controller ra Views
│   │   ├── 📁 Users/                  <-- ViewModels cho User
│   │   ├── 📁 Roles/                  <-- ViewModels cho Role
│   │   └── 📁 Products/               <-- ViewModels cho Sản Phẩm
│   │       └── ProductListViewModel.cs <-- ViewModel danh sách sản phẩm & phân trang
│   ├── 📁 Views/                      <-- Giao diện Razor Views (.cshtml) & Modals
│   │   ├── 📁 Users/
│   │   ├── 📁 Roles/
│   │   └── 📁 Products/               <-- Views & Modals cho Sản phẩm
│   │       ├── Index.cshtml           <-- Trang danh sách sản phẩm & phân trang
│   │       ├── Index.AdvancedSearch.cshtml <-- Partial view bộ lọc & tìm kiếm nâng cao
│   │       ├── _CreateModal.cshtml    <-- Modal popup tạo mới sản phẩm
│   │       └── _EditModal.cshtml      <-- Modal popup chỉnh sửa sản phẩm
│   ├── 📁 Startup/                    <-- Cấu hình Router, Menu Sidebar, Auth Middleware
│   │   └── MyProjectNavigationProvider.cs <-- Định nghĩa cây Menu ứng dụng
│   └── 📁 wwwroot/                    <-- Client-side Assets (JS, CSS, Libraries)
│       └── 📁 view-resources/Views/Products/
│           └── Index.js               <-- Script xử lý AJAX, Modal & thao tác CRUD sản phẩm ở giao diện
│
├── 📁 MyProject.Web.Core/             <--- [Web Core Layer: Shared Web Config & Security]
│   ├── 📁 Authentication/              <-- Cấu hình JWT Token & ASP.NET Identity
│   └── 📁 Controllers/                <-- Base Controllers dùng chung cho API / Web
│
└── 📁 MyProject.Migrator/             <--- [Tooling: Công cụ chạy Migration Database độc lập]
```

---

## 📦 Chức Năng Quản Lý Sản Phẩm (Products Module)

Module **Products** được xây dựng chuẩn theo kiến trúc N-Tier / DDD (Domain-Driven Design) của ABP Framework với các chức năng chi tiết sau:

### 1. Mô Hình Dữ Liệu (Domain Entities)
- **`Product`**: Thực thể chính lưu trữ thông tin sản phẩm (`Title`, `Description`, `Material`, `Status`, `CategoryId`, danh sách `Images`).
- **`ProductCategory`**: Thực thể danh mục sản phẩm (`Name`).
- **`ProductImage`**: Thực thể lưu trữ URL hình ảnh của từng sản phẩm.
- **`ProductStatus`**: Enum định nghĩa trạng thái kinh doanh của sản phẩm.

### 2. Xử Lý Nghiệp Vụ & DTOs (Application Layer)
- **`ProductAppService`**: Class xử lý toàn bộ logic nghiệp vụ bao gồm:
  - **Lấy danh sách & phân trang**: Hỗ trợ phân trang dữ liệu theo tham số trong `PagedProductResultRequestDto`.
  - **Tạo mới sản phẩm**: Tiếp nhận `CreateProductDto`, thực hiện lưu thông tin và hình ảnh liên kết.
  - **Cập nhật sản phẩm**: Tiếp nhận `UpdateProductDto` để chỉnh sửa thông tin.
  - **Xóa sản phẩm**: Thực hiện xóa sản phẩm khỏi cơ sở dữ liệu.
  - **Tìm kiếm / Lọc**: Lọc sản phẩm theo từ khóa tìm kiếm và các tiêu chí nâng cao.
- **`ProductMapProfile`**: Cấu hình **AutoMapper** giúp tự động ánh xạ dữ liệu giữa Entity và các DTOs.

### 3. Giao Diện Người Dùng (Presentation Layer)
- **`ProductsController`**: Điều hướng các Action hiển thị trang danh sách, tải dữ liệu phân trang và trả về Partial Views cho Modal.
- **ViewModels (`Models/Products/`)**:
  - **`ProductListViewModel`**: Chứa thông tin dữ liệu hiển thị cho trang danh sách sản phẩm gồm danh sách `Products`, tổng số lượng bản ghi `TotalCount`, trang hiện tại `CurrentPage`, kích thước trang `PageSize` và tổng số trang `TotalPages`.
- **Modals & Partial Views (`Views/Products/`)**:
  - **`Index.cshtml`**: Hiển thị danh sách sản phẩm dưới dạng thẻ/lưới, phân trang linh hoạt.
  - **`Index.AdvancedSearch.cshtml`**: Form lọc và tìm kiếm sản phẩm nâng cao.
  - **`_CreateModal.cshtml`**: Modal popup Bootstrap hỗ trợ tạo mới sản phẩm.
  - **`_EditModal.cshtml`**: Modal popup Bootstrap hỗ trợ tải dữ liệu động qua AJAX để chỉnh sửa thông tin sản phẩm.
- **JavaScript Client (`Index.js`)**:
  - Gửi yêu cầu **AJAX** gọi đến các AppService / Controller để xử lý thêm/sửa/xóa không gây reload trang.
  - Quản lý sự kiện đóng/mở Modal (`#ProductCreateModal`, `#ProductEditModal`), validate dữ liệu đầu vào và thông báo bằng **abp.notify**.
