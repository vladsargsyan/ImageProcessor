# Image Processing Plugin Framework (C#)

This repository contains a simple, object-oriented .NET framework designed to demonstrate a plugin-based architecture for image manipulation. The core idea is to allow easy addition and removal of image effects (plugins) without modifying the main application code. This project focuses on the framework's design and extensibility, rather than actual image processing.

## Table of Contents

* [Introduction](#introduction)

* [Features](#features)

* [Project Structure](#project-structure)

* [How to Use](#how-to-use)

* [Extensibility (Adding New Plugins)](#extensibility-adding-new-plugins)

* [Requirements](#requirements)

## Introduction

Imagine a web application that allows users to apply various effects to images. This project provides the foundational backend framework for such an application. It's built from scratch, adhering to object-oriented principles, and avoids any third-party frameworks to showcase a clean, extendable design.

The framework allows:

* Handling multiple images, each with its own set of desired effects.

* An easy system for adding/removing image operation "plugins" without altering the core application.

* Applying multiple effects to a single photo.

This project specifically implements the backend API logic; no user interface (UI) is included or required. The dummy plugins simulate image operations by printing messages to the console.

## Features

* **Plugin-Based Architecture:** Easily extendable with new image effects without modifying the core `ImageProcessor`.

* **Object-Oriented Design:** Clear separation of concerns using interfaces and classes.

* **Support for Multiple Effects:** Apply a sequence of effects to a single image.

* **Parameter Handling:** Effects can optionally accept parameters of various types.

* **Simulated Image Data:** Uses simple `ImageData` objects to represent images for demonstration purposes.

## Project Structure

The solution is organized into logical projects:

* **`ImageProcessor.Core`**: Contains core data structures, such as the `ImageData` class, which represents an image.

* **`ImageProcessor.Plugins`**: Defines the `IImageEffect` interface, which all image effect plugins must implement.

* **`ImageProcessor.DummyPlugins`**: Provides sample implementations of `IImageEffect` (e.g., `ResizeEffect`, `BlurEffect`, `GrayscaleEffect`) that simulate image operations by printing messages.

* **`ImageProcessor.Framework`**: Contains the `ImageProcessor` class, which is the central component responsible for managing and applying effects to images. It also handles plugin registration.

* **`ImageProcessor.ConsoleApp`**: A simple console application that demonstrates how to use the `ImageProcessor` to apply effects to simulated images, mimicking the example scenarios.

## How to Use

1. **Clone the repository:**
2. **Open the solution:** Open `ImageProcessor.sln` in Visual Studio (or your preferred C# IDE).
3. **Build the solution:** Build all projects within the solution.
4. **Run the ConsoleApp:** Set `ImageProcessor.ConsoleApp` as the startup project and run it.

The console application will demonstrate the framework in action by:

* Loading the dummy plugins.

* Creating simulated image data.

* Applying a predefined set of effects to each image, as described in the example scenarios.

* Printing messages to the console indicating which effects are being applied.

## Extensibility (Adding New Plugins)

To add a new image effect (plugin):

1. **Create a new C# class** that implements the `IImageEffect` interface (ideally within `ImageProcessor.DummyPlugins` or a new plugin project).

2. **Implement the `Name` property** to give your effect a unique name (e.g., "SepiaTone").

3. **Implement `ParameterName` and `ParameterType`** if your effect requires a parameter; otherwise, set them to `null`.

4. **Implement the `ApplyEffect` method**. This is where your image manipulation logic would go. For dummy plugins, simply print a message.
5. **Register the new plugin** in the `LoadPlugins` method of the `ImageProcessor` class (or through a more dynamic loading mechanism if implemented).

This design ensures that the core `ImageProcessor` class remains untouched when new effects are introduced, making the system highly modular and easy to maintain.

## Requirements

* .NET (e.g., .NET 6.0 or later, compatible with C# 10 or later)

* Visual Studio or a compatible C# IDE.
