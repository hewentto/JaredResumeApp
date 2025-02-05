using System.Collections.Generic;

namespace JaredResumeApp.Models
{
    public class Portfolio
    {
        public string FullName { get; set; } = "JARED DENNING";
        public string Title { get; set; } = ".NET Software Engineer";
        public string Location { get; set; } = "American Fork, Utah";
        public string PhoneNumber { get; set; } = "405-822-7237";
        public string Email { get; set; } = "jared@denningtech.com";
        public string AboutMe { get; set; } = "Always Learning, Always Training. As a dedicated Full-Stack .NET Developer with over three years of experience, I specialize in designing and implementing scalable software solutions using .NET, C#, Azure, and Angular. Proficient in cloud development, DevOps, CI/CD pipelines, and database management, I ensure high uptime and performance in every project. Passionate about leveraging emerging technologies like OpenAI and ChatGPT, I am committed to continuous improvement and delivering innovative, data-driven results through collaborative problem-solving.";

        public string Education { get; set; } = "BS Computer Science (Emphasis in Data Science), Brigham Young University - Idaho, Rexburg  ";
        public List<Skill> Skills { get; set; } = new List<Skill>()
                    {
                new Skill { Name = "ASP.NET", Description = "This website was built using ASP.NET Core and Blazor WebAssembly! I also have experience with ASP.NET backend using Entity Framework Core, and Angular for the front-end.", GitHubLink = "https://github.com/hewentto/JaredResumeApp" },
                new Skill { Name = ".NET Framework", Description = "Developed robust desktop applications using the .NET Framework, implementing both client and service components with elevated permissions. This architecture enhanced security and functionality, enabling seamless communication between the client-side interface and background services requiring higher-level access."},
                new Skill { Name = "C#", Description = "Worked 90% of the time with C# for 3 years. This web application was built using Razor Pages, which is a server-side templating system built into ASP.NET Core using C#.", GitHubLink = "https://github.com/hewentto/JaredResumeApp" },
                new Skill { Name = "Azure (Cloud Services)", Description = "This web application is hosted on Azure as an Azure Static Web App! I also managed Browsium's cloud service CI/CD pipelines using Azure DevOps and GitHub, ensuring smooth deployment and testing processes. I have also worked with Azure Functions, Azure Storage, and Azure SQL." },
                new Skill { Name = "Entity Framework Core (EF Core)", Description = "I have created MVC applications using EF Core to interact with SQL Server databases. I have also created RESTful APIs using EF Core to serve data to Angular applications, and MVC applications.", GitHubLink = "https://github.com/hewentto/StarFleetBuilder" },
                new Skill { Name = "Azure Storage", Description = "I have used Azure Storage solutions to store uploaded files from customer portals." },
                new Skill { Name = "Azure Functions", Description = "I have used Azure Functions to run cron jobs to verify the health of our cloud service and api endpoints."},
                new Skill { Name = "SQL", Description = "I have designed and implemented database schema updates using SQL Server and Microsoft SQL Server Management Studio, enhancing data integrity and improving query performance. Developed comprehensive data models and RESTful APIs for efficient CRUD operations using EF Core and Web API 2.", GitHubLink = "https://github.com/hewentto/StarFleetBuilder" },
                new Skill { Name = "Blazor", Description = "This web application was built using Blazor WebAssembly as a static site. I also have working knowledge of Blazor Server. Here is a link to this Blazor WASM application.", GitHubLink = "https://github.com/hewentto/JaredResumeApp" },
                new Skill { Name = "MVC Architecture", Description = "I have 3 years of professional experience using MVC architecture. I have built many applications using this architecture. Here is an example of an MVC application I built using EF Core to interact with a SQL database.", GitHubLink = "https://github.com/hewentto/StarFleetBuilder" },
                new Skill { Name = "Angular", Description = "I have project experience using Angular for the front-end." },
                new Skill { Name = "JavaScript", Description = "I have 3 years of professional experience using JavaScript, and project experience using TypeScript. This project uses JavaScript as well.", GitHubLink = "https://github.com/hewentto/JaredResumeApp" },
                new Skill { Name = "Windows Presentation Foundation (WPF)", Description = "I built an internal tool using WPF, and Open AI. This tool was used to generate 1,200 accurate, JSON-formatted definitions that cut manual labor by over 50%."},
                new Skill { Name = "Bootstrap", Description = "I have also worked with Bootstrap for front-end development the past 3 years. This website uses Bootstrap for styling, as well.", GitHubLink = "https://github.com/hewentto/JaredResumeApp" },
                new Skill { Name = "Python", Description = "I have used Python extensively for data analysis and machine learning projects. One of my projects used Python and OpenCV to process camera feed from a webcam, and learned to move the mouse cursor based on the detected motion.", GitHubLink = "https://github.com/hewentto/Ocular_Mouse_Control" },
                new Skill { Name = "C++", Description = "Part of Browsium's solutoin was desktop virualization using C++. I also have project experience during my time at BYU-I working with C++." },
                new Skill { Name = "Git", Description = "Over 6 years of experience using Git for version control. I have used Git for all of my professional projects." },
                new Skill { Name = "Agile Methodologies", Description = "I have utilized Agile methodologies for the past 3 years. I have experience working in an Agile environment, and have experience with Agile tools such as Azure DevOps." },
                new Skill { Name = "Microsoft SQL Server Management Studio", Description = "I have used SSMS to design and implement database schema updates, sproc changes, and more." }
            };
        public List<string> WorkExperience { get; set; } = new List<string>()
        {
            "Desktop Development: As an Engineer at Browsium I helped develop a desktop virtualization solution using C++ and .NET, enabling secure access to Windows applications. This project involved creating a lightweight client application, a service for elevated privileges  and a robust server infrastructure to deliver virtualized applications seamlessly.",
            "Cloud Development: Managed Browsium’s cloud service for 99.9% uptime on Azure. Incorporated Azure Functions and Hangfire background tasks triggers. Met with other departments, gathering feature requirements and implemented them.",
            "Full-stack Development: Worked on various full-stack projects, including Dashboard Features and Test Automation, utilizing .NET, C#, and relevant MVC frameworks.",
            "DevOps and CI/CD: Collaborated on the development and maintenance of CI/CD pipelines using Azure DevOps and GitHub, ensuring smooth deployment and testing processes.",
            "Testing and Quality Assurance: Developed and updated hundreds of unit tests using MSTestV2 and xUnit, increasing code coverage from 50% to 70% and ensuring high-quality, maintainable code. Implemented best practices for automated testing in new applications giving a solid foundation with 100% code coverage.",
            "Database and Data Management: Designed and implemented database schema updates using SQL Server and Microsoft SQL Server Management Studio, enhancing data integrity and improving query performance. Developed comprehensive data models and RESTful APIs for efficient CRUD operations using EF Core and Web API 2. Seamlessly integrated SQL databases with Angular front-end applications.",
            "Browser Extension Development: Migrated cross-platform browser extensions to MV3. Developed and updated browser extensions for Chrome, Edge, Firefox, and Safari, ensuring compatibility and functionality.",
            "Emerging Technologies: Leveraged OpenAI and ChatGPT to develop internal tools that generated 1,200 accurate, JSON-formatted definitions. These tools automated the definition creation process, reducing manual effort by over 50%. This innovation enhanced product integration and accelerated development cycles."
        };
    }
}