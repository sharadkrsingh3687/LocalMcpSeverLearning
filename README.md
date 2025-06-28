# Local MCP Server Sample

This repository contains a sample implementation of a Model Context Protocol (MCP) server using .NET 8 and the `ModelContextProtocol` library. The server communicates over standard input/output (stdio) and is configured using the Microsoft.Extensions.Hosting framework.

---

## Project Structure

```
LocalMcpSeverLearning/
├── .vscode/
│   └── mcp.json
├── Program.cs
├── sample.mcpserver.local.csproj
├── README.md
└── (other source files)
```

---

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- (Optional) Visual Studio 2022 or later, or Visual Studio Code

---

## Building the Project

Navigate to the project directory and run:

```sh
dotnet build sample.mcpserver.local.csproj
```

---

## Configure and Run MCP Server in VS Code

This project includes a `.vscode` folder with an `mcp.json` configuration file for running and debugging the MCP server in Visual Studio Code.

### 1. Configure MCP Server

Create or edit the `.vscode/mcp.json` file to specify server options and settings. Example:

```json
{
  "servers": {
        "sample-mcp-server": {
            "type": "stdio",
            "command": "dotnet",
            "args": [
                "run",
                "--project",
                "src/sample.mcpserver/sample.mcpserver.local/sample.mcpserver.local.csproj"
            ]
        }
    }
}
```

- **executable**: The command to launch the server (`dotnet` for .NET projects).
- **args**: Arguments to pass to the executable.
- **stdio**: Set to `true` to use standard input/output for communication.

---

### 2. Run MCP Server in VS Code (AI Agent Mode)

To run the MCP server as an AI Agent within Visual Studio Code:

1. **Open GitHub Copilot**  
   - Click the Copilot icon in the VS Code Activity Bar  
     *or*  
   - Use the Command Palette (`Ctrl+Shift+P`) and search for "GitHub Copilot".

2. **Select Agent Mode**  
   - In the Copilot panel, locate the mode selector (usually at the top or in the sidebar).
   - Choose **"Agent"** mode.

3. **Use Current File as `mcp.json`**  
   - Open your `.vscode/mcp.json` file in the editor.
   - In the Copilot Agent interface, select the option to use the currently open file as the MCP configuration.  
     *(This is typically labeled as "Use current file as MCP config" or similar.)*

4. **Start the MCP Server**  
   - Click the "Start" or "Run" button in the Copilot Agent panel.
   - The MCP server will launch using the configuration from your `.vscode/mcp.json` file, communicating over stdio.

5. **Monitor Output**  
   - View server logs and interactions in the integrated Terminal or Output pane.

---

> **Tips:**  
> - Make sure your `.vscode/mcp.json` file is saved and contains the correct configuration before starting the MCP server.
> - If the MCP server fails to start, try specifying the full path to your project file in the `args` section of `.vscode/mcp.json`.
> - Check the integrated Terminal or Output pane for error messages or logs to help troubleshoot issues.
> - Restart VS Code if configuration changes are not picked up as expected.




