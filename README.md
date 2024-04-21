# AutoTradingBot 

AutoTradingBot is a simple command-line application built to analyze various financial products using the Chain of Responsibility design pattern.

## Overview

The application allows users to input a product name and type and then analyzes the product to determine if it's worth buying. It incorporates historical performance data, market trends, expert ratings, and risk factors to make the analysis.

## Features

- Analyze stocks, commodities, forex, cryptocurrencies, and other currencies
- Determine the worthiness of a product based on historical performance, market trends, expert ratings, and risk factors
- Simple command-line interface for user interaction
- Extensible architecture using the Chain of Responsibility design pattern

## Installation

1. Clone the repository to your local machine.
2. Open the solution file (`ATB-ChainPattern.sln`) in Visual Studio.
3. Build the solution to restore dependencies and compile the project.
4. Run the `ATB-ChainPattern` project.

## Usage

1. Launch the application.
2. Follow the prompts to input a product name and type.
3. View the analysis result to determine if the product is worth buying.

## Project Structure

- `ATB-ChainPattern`: Main project containing the application code.
  - `BaseHandlers`: Contains the base handler class for the Chain of Responsibility pattern.
  - `ConcreteHandlers`: Contains concrete handler classes for specific product types.
  - `DummyData`: Contains dummy data classes representing products and their types.
  - `Program.cs`: Entry point of the application.

## Dependencies

- .NET Core/.NET Framework

## Contributors

- [Anthony Nguyen](https://github.com/AFONY10) - Project Lead

## NOTE: This is still a work in process in terms of expanding the functionality of the product.
The application do work if you intend to test the Chain-of-responsibility design pattern only. 
