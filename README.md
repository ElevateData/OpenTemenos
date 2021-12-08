# OpenTemenos

This application will a test suite and http client/proxy for [Temenos](https://temenos.com) managed by Elevate Data.

## Getting Started

First, an overview. Temenos is a web-based, core banking system. In order to interface with it, we need to be able to work with their REST APIs.
Their APIs are severely micro-serviced to the point that there are 400+ OpenApi specification documents used to interface will all endpoints that are currently active.
This is by no means an easy thing to work around. This is where the `OpenTemenos` library comes in. It is designed to be an organizational abstraction level to the main APIs. 
This also manages HttpClient creation to ensure that an app does not become thread starved. As such, virtually all the code for the class libraries that `OpenTemenos` references
are generated by references in the `*.csproj` and OpenApi `json/yaml` files and should almost never be edited directly.

### Installation process

When deploying there are a couple of parameters that mush be supplied. The currently required variables are:

- Temenos Credentials. These can be *either*
  - `TemenosCredential__ApiKey`
  - `TemenosCredential__UserName` *and* `TemenosCredential__Password`

### Software dependencies

Everything is included in the .NET6 SKD.

### Latest releases

Still working on the initial build. Most OpenApi specs have been read in and have a basic shell of integration testing created.

### API references

- [Temenos API Docs: Getting started](https://apidocs.temenos.com/getting-started) - the primary source of documentation.
- [GitHub: Temenos APIs](https://github.com/temenos/APIs/) - a GutHub repo that the Temenos team uses to host all the OpenApi specs used in the previous website. 
A copy of this is what is used in this application.

## Build and Test

TODO: Describe and show how to build your code and run the tests.

Create a copy of the `OpenTemenos.Tests.testsettings.template.json` called `OpenTemenos.Tests.testsettings.json` and update the specified fields. 
If you populate the ApiKey field, username and password will be ignored.

Build the code like always. Unit testing can be run in bulk.

## Contribute

TODO: Explain how other users and developers can contribute to make your code better.