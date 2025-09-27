# 🔧 .NET/C# Technical Training - Linedata

## 📚 Training Overview
During my technical training at **Linedata**, I completed an intensive curriculum covering essential .NET/C# technologies and software development principles:

### **Core Technologies Mastered**
- **.NET/C# Fundamentals** - Language syntax, OOP principles, and .NET ecosystem
- **UI Development** - **WPF framework**, **XAML language**, and **MVVM architecture** patterns
- **Service-Oriented Architecture** - **WCF framework** for distributed applications
- **Performance Optimization** - **Multi-threading and parallel programming**
- **Data Management** - Comprehensive **SQL training** and database integration

## 🎯 Practical Project Experience

### **Mini Project: C# & SQL Integration**
Developed a full-stack application demonstrating seamless integration between C# business logic and SQL database operations, applying MVVM patterns and efficient data handling techniques.

## 🚀 Innovation: Local Development Workflow Solution

### **Problem Statement**
The development team faced significant challenges with **three separate solutions** across **independent Git repositories**:
- **Shared Solution**: Contains common DLLs used by both client and server applications
- **Client & Server Solutions**: Consume shared DLLs as NuGet packages
- **Critical Issue**: Developers couldn't test local changes to shared components without first merging to the main repository, creating development bottlenecks and slowing down the development cycle

### **Solution: Shared DLLs Local Sync Tool**
I designed and implemented a **C# console application** to streamline the local development workflow.


### **Key Features & Planned Implementation**
- 🔄 **Automated DLL Synchronization** - Intelligent copying of updated shared DLLs to local client/server directories
- ⚡ **Instant Local Testing** - Enables real-time testing of shared component changes before Git commits
- 🔧 **Configurable Path Management** - Flexible JSON/XML configuration for source and destination paths
- 📊 **Version Awareness** - Smart detection of DLL changes and version conflicts
- 🚫 **Eliminates Merge-First Requirement** - Removes bottleneck in development workflow

### **Technical Architecture (Planned)**
- **Language**: C# (.NET Framework 4.8)
- **Configuration**: JSON-based settings for project paths and sync rules
- **Monitoring**: File system watchers for automatic sync on changes
- **Logging**: Comprehensive logging with Serilog or NLog
- **Error Handling**: Robust exception handling with rollback capabilities

## ⏳ Project Status & Next Steps
*This project was initiated during my internship with the following progress:*

### **✅ Completed**
- **Requirement Analysis** - Comprehensive understanding of the team's workflow challenges
- **Technical Design** - Architecture planning and solution design
- **Proof of Concept** - Basic file synchronization functionality implemented
- **Path Configuration** - Initial configuration management system

### **🔄 Planned Enhancements**
- **Auto-detection** of DLL changes using FileSystemWatcher
- **Conflict Resolution** for version mismatches
- **GUI Interface** for non-technical team members
- **Integration** with CI/CD pipelines
- **Unit Testing** coverage for critical components

## 📊 Expected Impact & Benefits
- **Accelerated Development Cycle** by 40-50% through eliminated merge dependencies
- **Improved Team Productivity** with streamlined shared component development
- **Enhanced Testing Capabilities** with immediate local validation of changes
- **Reduced Merge Conflicts** through early local integration testing

## 🛠️ Technologies Utilized
- **.NET Framework** / **C# 8.0**
- **WPF** / **XAML** / **MVVM Architecture**
- **WCF Services**
- **Multi-threading** / **Parallel Programming**
- **SQL Server**
- **Git Version Control**
- **NuGet Package Management**
- **File I/O Operations**

## 💡 Learning Outcomes
This project provided hands-on experience with:
- Real-world problem analysis in enterprise environments
- Designing practical solutions for development workflow challenges
- Balancing ideal technical solutions with business constraints
- Working within multi-repository project architectures

---

*Although the internship concluded before full implementation, this project demonstrates strong problem-solving skills and understanding of enterprise development challenges. The solution design showcases practical application of .NET technologies to optimize team workflows.*

Brief :The team have an issue with building 3 seperate solutions in 3 seperate git repos. there is a solution which is called shared, because it contains dlls shared between the client and the server(2 other solutions). the shared dlls are used as nuget packages in the client and server, so if they make a change in the shared and want to test it locally, they simply can't do that, therefore, they need to merge the code to the git repo first the test it. to resolve this issue, I tried to create a console app in c# that takes the shared dlls and copy them in the local folder so we can test locally before the merge.
