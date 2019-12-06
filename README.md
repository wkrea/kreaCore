# kreaCore

[![krea.Core package in kreaCore@Local feed in Azure Artifacts](https://feeds.dev.azure.com/javiertrigos88/7053f183-58c7-41fb-8253-57396bdc1de1/_apis/public/Packaging/Feeds/216f9451-f083-448e-afba-10523986517d%400493c2a5-824b-401f-bfaf-714d5eca3bc1/Packages/e8b1b47b-12d2-4275-a343-b8b08d7bfa98/Badge)](https://dev.azure.com/javiertrigos88/kreaCore/_packaging?_a=package&feed=216f9451-f083-448e-afba-10523986517d%400493c2a5-824b-401f-bfaf-714d5eca3bc1&package=e8b1b47b-12d2-4275-a343-b8b08d7bfa98&preferRelease=true)


Mi Librería Genérica Core convertida en Nugget guiado de tutorial https://medium.com/@dan.cokely/creating-nuget-packages-in-azure-devops-with-azure-pipelines-and-yaml-d6fa30f0f15e


## Como constuir Nuget desde PipeLine de DevOpsAzure
https://stackoverflow.com/questions/58856604/azure-devops-publish-nuget-to-hosted-feed/59204574#59204574

## Como acceder a los paquetes desde VSTudio
  
Usando los parametros definidos en `javiertrigos88/kreaCore/Artifacts/Packages` y el botón `Connect to Feed`
```xml
<add key="kreaCore" value="https://pkgs.dev.azure.com/javiertrigos88/kreaCore/_packaging/kreaCore/nuget/v3/index.json" />
```
Puede mirarse en la carpeta `Docs\Access2Nuget` para mas detalles




Recursos
* https://www.youtube.com/watch?v=ESdvXlrG9zQ&list=PLUOequmGnXxOgmSDWU7Tl6iQTsOtyjtwU&index=3&t=416s
* https://www.thereformedprogrammer.net/genericservices-a-library-to-provide-crud-front-end-services-from-a-ef-core-database/
* https://github.com/JonPSmith/EfCore.GenericServices
* https://code-maze.com/net-core-series/
* https://www.benday.com/2017/05/03/walkthrough-use-a-package-from-a-private-nuget-server-in-tfs2017/
