# Portfolio Website - [DenningTech.com](https://www.denningtech.com/)

Welcome to the repository for my personal portfolio website, [DenningTech.com](https://www.denningtech.com/). This site currently showcases my professional resume with options to share and download it. Built with modern web technologies, it aims to provide a seamless and responsive user experience.

## Table of Contents

- [Features](#features)
- [Tech Stack](#tech-stack)
- [Getting Started](#getting-started)
- [Continuous Integration and Deployment](#continuous-integration-and-deployment)
- [Contact](#contact)

---

## Features

- **Resume Display**: View my professional resume directly on the website.
- **Download Option**: Easily download the resume in PDF format.
- **Share Functionality**: Share the resume via copying the url.
- **Responsive Design**: Optimized for all devices, including desktops, tablets, and mobile phones.
- **Modern UI**: Utilizes Bootstrap symbols for a clean and intuitive user interface.

## Tech Stack

### Frontend

- **[Blazor WebAssembly](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)**: A framework for building interactive client-side web UIs with .NET.
- **[Bootstrap](https://getbootstrap.com/)**: A popular CSS framework for designing responsive and mobile-first websites.

### Hosting

- **[Azure Static Web Apps](https://azure.microsoft.com/services/app-service/static/)**: Provides free hosting for static sites with integrated APIs, custom domains, and SSL certificates.

### Continuous Integration and Deployment

- **[GitHub Actions](https://github.com/features/actions)**: Automates the build and deployment process using Azure Static Web Apps default workflow.

---
## Continuous Integration and Deployment

The project uses GitHub Actions for continuous integration and deployment. The default Azure Static Web Apps workflow is configured to build and deploy the app whenever changes are pushed to the `main` branch.

### Workflow Details

- **Location**: `.github/workflows/azure-static-web-apps.yml`
- **Triggers**:
  - On push to `main` branch
  - On pull request to `main` branch
- **Jobs**:
  - **Build and Deploy**: Uses the Azure Static Web Apps Build engine to build the Blazor WebAssembly app.
- **Environment Variables**:
  - **Azure Credentials**: Stored securely in GitHub Secrets.

### Customization

You can customize the workflow by editing the `.yml` file to include additional build steps, tests, or deployment configurations.

## Contact

- **Website**: [DenningTech.com](https://www.denningtech.com/)
- **Email**: [your.email@example.com](mailto:your.email@example.com)
- **LinkedIn**: [Your Name](https://www.linkedin.com/in/yourprofile)

Feel free to reach out for any inquiries or collaboration opportunities.
