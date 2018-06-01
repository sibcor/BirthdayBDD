#error Элемент <unitTestProvider> может встречаться один раз в данном разделе.
#error System.Configuration
#error Server stack trace: 
#error    в System.Configuration.ConfigurationElement.DeserializeElement(XmlReader reader, Boolean serializeCollectionKey)
#error    в System.Configuration.ConfigurationSection.DeserializeSection(XmlReader reader)
#error    в TechTalk.SpecFlow.Configuration.ConfigurationSectionHandler.CreateFromXml(String xmlContent)
#error    в TechTalk.SpecFlow.Configuration.ConfigurationLoader.Load(SpecFlowConfiguration specFlowConfiguration, ISpecFlowConfigurationHolder specFlowConfigurationHolder)
#error    в TechTalk.SpecFlow.Generator.Configuration.GeneratorConfigurationProvider.LoadConfiguration(SpecFlowConfiguration specFlowConfiguration, SpecFlowConfigurationHolder specFlowConfigurationHolder)
#error    в TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.CreateContainer(SpecFlowConfigurationHolder configurationHolder, ProjectSettings projectSettings)
#error    в TechTalk.SpecFlow.Generator.TestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
#error    в System.Runtime.Remoting.Messaging.StackBuilderSink._PrivateProcessMessage(IntPtr md, Object[] args, Object server, Object[]& outArgs)
#error    в System.Runtime.Remoting.Messaging.StackBuilderSink.SyncProcessMessage(IMessage msg)
#error Exception rethrown at [0]: 
#error    в System.Runtime.Remoting.Proxies.RealProxy.HandleReturnMessage(IMessage reqMsg, IMessage retMsg)
#error    в System.Runtime.Remoting.Proxies.RealProxy.PrivateInvoke(MessageData& msgData, Int32 type)
#error    в TechTalk.SpecFlow.Generator.Interfaces.ITestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
#error    в TechTalk.SpecFlow.IdeIntegration.Generator.AppDomain.RemoteAppDomainTestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
#error    в TechTalk.SpecFlow.IdeIntegration.Generator.GeneratorServices.CreateTestGenerator()
#error    в TechTalk.SpecFlow.IdeIntegration.Generator.IdeSingleFileGenerator.GenerateCode(String inputFilePath, String inputFileContent, GeneratorServices generatorServices, ProjectSettings projectSettings)
#error    в TechTalk.SpecFlow.IdeIntegration.Generator.IdeSingleFileGenerator.Generate(String inputFilePath, String inputFileContent, GeneratorServices generatorServices, CodeDomHelper codeDomHelper, ProjectSettings projectSettings)