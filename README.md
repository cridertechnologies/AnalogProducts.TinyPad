# TinyPad

A tiny text editor for Windows built with .NET 10.0.

## Description

TinyPad is a lightweight, simple text editor designed for Windows. It provides essential text editing capabilities with a clean and intuitive interface, making it perfect for quick note-taking and basic text file editing.

## Features

- **File Operations**
  - Create new documents
  - Open existing text files
  - Save and Save As functionality
  - Support for .txt files and all file types

- **Text Formatting**
  - Customizable font family, size, and style
  - Word wrap toggle
  - Clear all formatting option
  - Persistent formatting preferences

- **User Experience**
  - Clean, intuitive interface
  - Automatic configuration persistence
  - Resizable window
  - Centered screen positioning on launch

## Prerequisites

- Windows operating system
- .NET 10.0 Runtime or SDK

## Building from Source

1. Clone the repository:
   ```bash
   git clone https://github.com/cridertechnologies/AnalogProducts.TinyPad.git
   cd AnalogProducts.TinyPad
   ```

2. Build the project using .NET CLI:
   ```bash
   dotnet build
   ```

3. Run the application:
   ```bash
   dotnet run
   ```

## Installation

To create a standalone executable:

```bash
dotnet publish -c Release
```

The published files will be available in the `bin/Release/net10.0-windows/publish/` directory.

## Usage

1. Launch TinyPad
2. Use the File menu to create new documents or open existing ones
3. Edit your text in the main text area
4. Customize the font and formatting using the Format menu
5. Save your work using File > Save or Save As

### Configuration

TinyPad automatically saves your preferences (font settings, word wrap) to:
```
%APPDATA%\TinyPad\appconfig.json
```

## License

This project is licensed under the MIT License. See the [LICENSE.txt](LICENSE.txt) file for details.

## Author

Copyright 2025 Crider Technologies LLC

## Contributing

Contributions are welcome! Please feel free to submit pull requests or open issues for bugs and feature requests.
