# Animation2Tilemap

![workflow](https://img.shields.io/github/actions/workflow/status/vonhoff/Animation2Tilemap/dotnet.yml)
[![version](https://img.shields.io/badge/version-1.2.1-blue)](https://github.com/vonhoff/Animation2Tilemap/releases)
[![version](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

Animation2Tilemap is a tool to easily convert images or animated images to tilemaps and tilesets.

The files generated by Animation2Tilemap can be imported into [Tiled](https://www.mapeditor.org/) for further editing
and customization. This tool provides both a command-line interface and an easy-to-use GUI option.

## Features

Animation2Tilemap offers the following features:

- Support for various input formats, including Bmp, Gif, Jpeg, Pbm, Png, Tiff, Tga, and WebP.
- Process animations to tilemaps from either folders or images that contain multiple frames.
- Generate an animated tileset from an image or a folder containing extracted animation frames.
- Customize the tile size, transparent color, and frame duration of your animations.
- Generate tilesets and tilemaps in Tiled compatible formats, such as base64, zlib, gzip, and csv.

## Example Use Case

Using this tool, you can convert the following animation into an animated tileset and tilemap. It results in a set
of PNG, TSX, and TMX files that collectively represent the original image.

|        Input Image        |      Resulting Output       |
|:-------------------------:|:---------------------------:|
| ![Input image](input.gif) | ![Output image](result.png) |

Image source: https://x.com/jmw327/status/1405872936783802384

## Installation

Before installing Animation2Tilemap, make sure you have the .NET 8 runtime installed on your system. You can get it
from https://dotnet.microsoft.com/en-us/download/dotnet/8.0

To install Animation2Tilemap, you need to follow these steps:

- Go to the [releases page](https://github.com/vonhoff/Animation2Tilemap/releases) and download the latest version.
- Extract the zip file to a folder of your choice. You can use any file manager or unzip utility to do this.

## Command-line Usage

Open a terminal and go to the folder where you installed Animation2Tilemap. To convert an animation into a tileset and
tilemap, run this command: `animation2tilemap.console -i <input> -o <output>` where `<input>` and `<output>` are the
paths to the animation and output folders.

To see the help page within the command-line application, you can run the console application with the `--help` option.
This will show you the available options and parameters that you can use.

You can also specify other options to customize the output, such as:

| Option                                    | Description                                           | Default    |
|-------------------------------------------|-------------------------------------------------------|------------|
| `-d` `--duration <duration>`              | The duration of each animation frame in milliseconds. | `125`      |
| `-h` `--height <height>`                  | The height of each tile in pixels.                    | `8`        |
| `-w` `--width <width>`                    | The width of each tile in pixels.                     | `8`        |
| `-m` `--margin <margin>`                  | The margin around the tiles.                          | `0`        |
| `-s` `--spacing <spacing>`                | The spacing between the tiles.                        | `0`        |
| `-t` `--transparent <transparent>`        | The transparent color in RGBA format.                 | `00000000` |
| `-f` `--format <base64\|zlib\|gzip\|csv>` | The format of the tile layer data.                    | `zlib`     |
| `-v` `--verbose`                          | Enables verbose logging for debugging purposes.       | `false`    |
| `-?` `--help`                             | Shows help and usage information.                     |            |

## Screenshot

![Program screenshot](screenshot.png)

## Motivation

I was inspired by classic isometric games like Populous. My goal was to replicate that style in my own projects by using
[Tilengine](https://www.tilengine.org/) as a rendering engine. However, I encountered a challenge due to its lack of
native support for diamond isometric tiles.

Tilengine does not support diamond tiles because standard 2D chipsets do not support them either. Classic isometric
games, such as Populous, used standard square tiles that were diagonally split. This combination of corners from
different diamond tiles gave the illusion of isometric tiles.

To work around this, I divided pre-rendered animated images into square tiles. This approach allowed me to integrate
animated elements into an orthographic tileset. However, the process was cumbersome. It involved manual extraction,
slicing, and filtering for duplicates, as well as organizing the tiles. I created this tool to automate that process.

## Acknowledgments

If you find Animation2Tilemap useful in your projects, consider leaving a star! ⭐

## Contribution

If you want to contribute to Animation2Tilemap, you are welcome to submit pull requests or report issues on GitHub.
