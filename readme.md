# Shastra Soft

Shastra Soft is a responsive ASP.NET public website for a Surat-based IT company. The site serves as the primary marketing and lead-generation platform, showcasing web, mobile, and desktop app development, UI/UX and brand identity design, digital marketing, SEO, cloud, and system integration services. It features a project portfolio, team profiles, client testimonials, and a comprehensive contact system. The portal is SEO-friendly, mobile-ready, and designed to convert visitors into clients.

## Features

- **Public landing pages** — engaging home, about, services, portfolio, team, testimonials, and contact pages.
- **Service showcase** — detailed pages for core services:
  - Web Development (ASP.NET, Core, PHP, React, Angular, etc.)
  - Mobile App Development (iOS, Android, Flutter, React Native)
  - Desktop App Development
  - UI/UX Design & Brand Identity
  - Digital Marketing & SEO
  - Cloud & System Integration
- **Project portfolio** — interactive case studies and project showcase with images and tech stack details.
- **Team profiles** — introduction to the team members, their roles, and expertise.
- **Client testimonials** — showcasing client feedback and success stories.
- **Contact & inquiry forms** — lead generation forms with validation, plus direct email and WhatsApp integration.
- **Careers page** — showcase of current job openings and application submission.
- **SEO-friendly** — clean URLs, meta titles/descriptions, canonical tags, Open Graph tags, sitemap, and `robots.txt`.
- **Mobile-ready** — responsive layout optimized for mobile, tablet, and desktop.
- **Shared web UI** — Razor views, shared layout, partials, pagination helper, and client-side validation.

> Feature descriptions are based on the pages, domain models, and views present in this repository. Actual behavior may depend on the connected database and configuration.

## Technology stack

- C# and .NET Framework 4.8 (or `<your target framework>`)
- ASP.NET MVC with Razor views
- Bootstrap for responsive UI
- HTML, CSS, JavaScript, and jQuery
- Visual Studio solution (`ShastraSoft.sln`)
- Entity Framework + SQL Server for content, portfolios, inquiries, and careers
- SEO tooling: meta tags, sitemap, and `robots.txt`

## Solution structure

```text
V4/
├── ShastraSoft.sln
├── ShastraSoft/                           # ASP.NET MVC public website
│   ├── Controllers/                       # Public + admin controllers
│   ├── Views/                             # Razor UI pages
│   │   ├── Shared/                        # Layout and partials
│   │   ├── Home/                          # Landing pages
│   │   ├── Services/                      # Service detail pages
│   │   ├── Portfolio/                     # Project case studies
│   │   ├── Team/                          # Team member profiles
│   │   ├── Testimonials/                  # Client reviews
│   │   ├── Careers/                       # Job listings and application
│   │   └── Contact/                       # Contact forms
│   ├── Content/                           # CSS, JS, images, fonts
│   ├── App_Start/                         # Routes, filters, DI setup
│   ├── Config/                            # Environment-specific app settings
│   └── Web.config
├── ShastraSoft.Domain/                    # Domain models and list/pagination models