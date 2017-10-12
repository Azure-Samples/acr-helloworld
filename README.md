# ACR-Helloworld

This sample is a very simple Asp.net Core application used to demonstrate Azure Container Registry features.

## Features

This project framework provides the following features:

* A map highlighting the source region of the Azure Container Registry

### Quickstart

1. `git clone https://github.com/Azure-Samples/acr-helloworld.git`
2. `cd acr-helloworld`
3. `docker-compose build`
or `docker build . -f .\AcrHelloworld\Dockerfile -t acr-helloworld`
4. `docker run -d -p 8080:80 acr-helloworld`
5. Browse: http://localhost:8080

## Resources

- [Azure Container Registry Service](https://aka.ms/acr)
- [Azure Container Registry Docs](https://aka.ms/acr/docs)
- [Azure Container Registry Geo-replication overview](https://docs.microsoft.com/en-us/azure/container-registry/container-registry-geo-replication)
- [Azure Container Registry Geo-replication tutorial](https://docs.microsoft.com/en-us/azure/container-registry/container-registry-tutorial-prepare-app)

# Contributing

This project welcomes contributions and suggestions.  Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit https://cla.microsoft.com.

When you submit a pull request, a CLA-bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., label, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.