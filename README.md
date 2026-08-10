# Folder Visualizer

Folder Visualizer is a C# application that reads a directory from the file system and visualizes its folder and file structure.

The application recursively traverses the selected directory, builds an in-memory tree representing folders and files, calculates the required visualization dimensions, and renders the result in either a vertical or horizontal layout.

## Architecture

![Folder Visualizer Architecture](./image.png)
The project is divided into several main components:

- **DocumentComponent**  
  Defines the common abstraction for files and folders.

- **File**  
  Represents an individual file and stores information such as its name, extension, and size.

- **Folder**  
  Represents a directory and contains a collection of other `DocumentComponent` objects, allowing folders to contain both files and nested folders.

- **FolderLoader**  
  Recursively traverses the selected directory and builds the folder/file object tree.

- **Sizer**  
  Calculates the space required to render the folder structure in vertical or horizontal layouts.

- **FolderDrawer**  
  Uses the generated folder tree and calculated dimensions to draw the visualization.

- **Main Form**  
  Coordinates the loading and drawing process through the application's UI.

## Design Pattern

The core of the project uses the **Composite Design Pattern**.

Both `File` and `Folder` inherit from `DocumentComponent`, which allows the application to treat individual files and groups of files/folders through the same interface.

```text
DocumentComponent
├── File
└── Folder
    ├── File
    ├── File
    └── Folder
        └── File

In this structure:

DocumentComponent is the Component
File is the Leaf
Folder is the Composite

This pattern fits the project naturally because a file system itself has a hierarchical tree structure.

How It Works
User selects a directory
        ↓
FolderLoader
        ↓
Builds Folder / File tree
        ↓
Sizer calculates visualization dimensions
        ↓
FolderDrawer renders the structure
        ↓
Visualization displayed in the UI

I particularly like keeping the **Design Pattern** section because this repo becomes much more interesting when someone looking at your GitHub realizes that it isn't just a folder drawing program—you actually implemented the **Composite Pattern** to model the filesystem hierarchy.

One small suggestion: instead of putting that huge UML image directly at the top of the README, put a short
