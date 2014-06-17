using simV.info.Models;
using System;
using System.Collections.ObjectModel;

namespace simV.info.ViewModels
{
    public class ProjectsViewModel
    {
        public ObservableCollection<Project> Projects { get; internal set; }

        public ProjectsViewModel()
        {
            Projects = new ObservableCollection<Project>();

            Projects.Add(new Project()
            {
                Name = "Ada to C++",
                Description = "In today’s development environment, speed in getting a solution from development to deployment is critical. Often, mission specific knowledge is locked into legacy Ada code, precluding its use or re-­use where a C++ solution is needed. In these situations, SimVentions utilizes the Ada2CC tool for translating legacy Ada code to C++.",
                Link = "http://simventions.net/ada2c",
                ImageSource = "http://simventions.net/images/innovations/ada2c-icon.png"
            });

            Projects.Add(new Project()
            {
                Name = "ARRT",
                Description = "Acquisition Requirements Roadmap Tool (formally the Automated Requirements Roadmap Tool), is a job assistance tool used to write performance-based requirements and automatically create a Performance Work Statement (PWS), Quality Assurance Surveillance Plan (QASP), and Performance Requirement Summary (PRS). ARRT uses a proven step-by-step approach that guides users through the process of creating well-written High Level Objectives, Tasks, Standards, and Inspection procedures.",
                Link = "http://www.simventions.net/arrt",
                ImageSource = "http://simventions.net/images/innovations/arrt-icon.png"
            });

            Projects.Add(new Project()
            {
                Name = "Artillery Modeler",
                Description = "The Navy needed to quickly and accurately model the flight of artillery and prototype munitions with 2D and 3D visualization space. In response, SimVentions deployed the Artillery Modeler, which incorporates different projectile models, leverages Google Earth for 3D visualization, and can account for weather and random variance. Artillery Modeler is a powerful tool for creating simulated environments for munitions testing.",
                Link = "http://www.simventions.net/artillerymodeler",
                ImageSource = "http://simventions.net/images/innovations/artillerymodeler-icon.png"
            });

            Projects.Add(new Project()
            {
                Name = "Conceptual Works",
                Description = "Planners and architects need an engineering and analysis tool for quickly modeling the representation and behavior of systems, environments, simulations, humans, software, and their composition. In response, SimVentions developed the Conceptual Works tool, which provides an intuitive UML designer and uses the SISO Base Object Model (BOM) standard for capturing reusable models and providing the answer that planners need.",
                Link = "http://simventions.net/conceptualworks",
                ImageSource = "http://simventions.net/images/innovations/conceptualworks-icon.png"
            });

            Projects.Add(new Project()
            {
                Name = "DART",
                Description = "Project Managers and Engineers need to easily trace requirements, design, code and test artifacts to assess data completeness and identify shortfalls, gaps, and deficiencies. In response, SimVentions developed the Development Automated Relationship Tracker (DART) Tool, which provides a graphical view of all data relationships throughout the system engineering process and identifies technical risks.",
                Link = "http://www.simventions.net/dart",
                ImageSource = "http://simventions.net/images/innovations/dart-icon.png"
            });

            Projects.Add(new Project()
            {
                Name = "DEXTER",
                Description = "Systems often need to interoperate across different middleware and tactical communication infrastructures quickly and easily. In response, SimVentions developed an innovation called Deployment and Extraction Tools for Services (DEXTER) that enables the integration of components and systems that use different middleware without the need to redesign, redevelop, and retest existing software.",
                Link = "http://www.simventions.net/dexter",
                ImageSource = "http://simventions.net/images/innovations/dexter-icon.png"
            });

            Projects.Add(new Project()
            {
                Name = "DF-­ASSET",
                Description = "SimVentions has aided in the development of advanced data fusion technology through the Data Fusion Algorithm Simulation, Stimulation, and Evaluation Tool (DF-­ASSET) Test Bed, which is used for verifying and validating sensor fusion engines. DF-­ASSET provides a repeatable and easy to use desktop environment to test early stage development of fusion algorithms that combine and resolve target data from multiple on-board and off-board sensors.",
                Link = "http://www.simventions.net/df-asset",
                ImageSource = "http://simventions.net/images/innovations/dfasset-icon.png"
            });

            Projects.Add(new Project()
            {
                Name = "EMBR",
                Description = "Enterprise Metacard Builder Resource (EMBR) Portal is a web-based, GOTS tool that enables engineers and senior decision-makers to easily capture, analyze, and reuse M&S assets and metadata.",
                Link = "http://simventions.net/embr",
                ImageSource = "http://simventions.net/images/innovations/embr-icon.png"
            });

            Projects.Add(new Project()
            {
                Name = "InformdB",
                Description = "Automatically Discover Data Relationships Project managers and analysts struggle seeing and understanding the relationships in their data. In response, SimVentions developed a tool kit called Informedb, which offers dynamic views to allow stakeholders to quickly interpret and understand data visually.",
                Link = "http://www.informedb.com",
                ImageSource = "http://simventions.net/images/innovations/informedb-icon.png"
            });

            Projects.Add(new Project()
            {
                Name = "InformeNet",
                Description = "InformeNet provides insight into components on a publish/subscribe network. This tool can be used to monitor, inject, record, and validate messages from all components participating in a given Data Distribution System (DDS) domain.",
                Link = "http://www.simventions.net/informenet",
                ImageSource = "http://simventions.net/images/innovations/informenet-icon.png"
            });

            Projects.Add(new Project()
            {
                Name = "Mission Task Analysis Tool",
                Description = "Provides the Human Systems Integration (HSI) workforce a way to carry out a structured task analysis for projects and programs. MTAT facilitates the planning, organization, assessment, reporting, and recommendations required for guiding, building, and sharing various task analysis processes and products.",
                Link = "http://www.simventions.net/mtat",
                ImageSource = "hhttp://simventions.net/images/innovations/mtat-icon.png"
            });

            Projects.Add(new Project()
            {
                Name = "PMaP",
                Description = "Program Management and Planning (PMaP) tool suite, allows a program manager to track cost, schedules and risks in an integrated fashion. The tool suite utilizes existing commercial products including Microsoft Project, Microsoft Excel, and Microsoft PowerPoint. PMaP also is Navy Marine Corps Intranet (NMCI) compatible.",
                Link = "http://www.simventions.net/pmap",
                ImageSource = "http://simventions.net/images/innovations/pmap-icon.png"
            });

            Projects.Add(new Project()
            {
                Name = "ProEd Training",
                Description = "SimVentions’ Professional Education (ProEd) Offers Dynamic Transformational Training for Professionals, Leaders, Teachers, and College Students",
                Link = "http://www.proed-training.com",
                ImageSource = "http://simventions.net/images/innovations/proed-icon.png"
            });

            Projects.Add(new Project()
            {
                Name = "Service Acquisition Mall",
                Description = "SAM provides a “hands-on” resource for getting real world examples for writing performance based contracts.  The website uses the same Seven Step Sourcing process contained in DAU’s Service Acquisition Workshop (SAW) and ACQ 265 Mission Focused Service. SAM is an initiative to enhance the government’s ability to acquire services more effectively. It leverages previously gained knowledge to improve service acquisition outcomes on a 24/7 basis. The Mall contains a directory of “stores” organized into wings which enable acquisition teams to find tools, current samples, examples, market research and training information for the service they are purchasing.",
                Link = "http://www.simventions.net/sam",
                ImageSource = "http://simventions.net/images/innovations/dau-icon.png"
            });

            Projects.Add(new Project()
            {
                Name = "Service Acquisition Workshop",
                Description = "The SimVentions team has developed and pioneered the concept and delivery of Service Acquisition Workshops (SAWs).  SAWs are an effective process that facilitates the defining of a Request for Proposal’s (RFP) Performance Work Statement (PWS), Quality Assurance Surveillance Plan (QASP), and Performance Requirements Summary (PRS).  This performance-based approach focuses on outcomes. The SimVentions solution uses the Acquisition Requirements Roadmap Tool (ARRT) to effectively use your time while helping to shorten acquisition lead times and increase acquisition approval rates.",
                Link = "http://simventions.net/saw",
                ImageSource = "http://simventions.net/images/innovations/saw-icon.png"
            });

            Projects.Add(new Project()
            {
                Name = "Work Log Manager",
                Description = "Working hand-in-hand with Builders Choice Excavating (BCE), a local area concrete company, SimVentions’ took on the task of automating their work scheduling and management processes. In less than 48 hours, the work scheduling and management processes were mapped and represented in a web-driven real-time environment, and presented to the customer. Work Log Manager has now been the go-to app for BCE for over eight years.",
                Link = "http://www.simventions.net/worklogmanager",
                ImageSource = "http://simventions.net/images/innovations/work-log-manager-icon.png"
            });


        }
    }
}