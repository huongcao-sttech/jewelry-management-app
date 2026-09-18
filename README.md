# MyProject - Overview & Architecture Guide

Hệ thống được phát triển trên nền tảng **ASP.NET Core MVC & jQuery** sử dụng **ABP Framework (ASP.NET Boilerplate)**.

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
