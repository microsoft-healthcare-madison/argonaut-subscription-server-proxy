# argonaut-subscription-server-proxy

A .Net Core application to work with the proposed Argonaut Subscription changes.

This system sits in front of a FHIR R4 Server and intercepts all calls relating 
to these scenarios.  It handles triggering and sending notifications via the 
specified channels to clients.  This was done to highlight the areas needed to 
implement the Server portion of Subscription handling.

An implementer may choose to take a similar approach (of proxying calls), or may
use a modified server directly.  Either option should result in the same behavior.

# Usage

- Coming Soon

## To Do:


## Contributing
This project welcomes contributions and suggestions.  Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit https://cla.microsoft.com.

When you submit a pull request, a CLA-bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., label, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

There are many other ways to contribute to FHIR Server for Azure.
* [Submit bugs](https://github.com/microsoft-healthcare-madison/argonaut-subscription-server-proxy/issues) and help us verify fixes as they are checked in.
* Review the [source code changes](https://github.com/microsoft-healthcare-madison/argonaut-subscription-server-proxy/pulls).
* Engage with users and developers on [Official FHIR Zulip](https://chat.fhir.org/)
* [Contribute bug fixes](CONTRIBUTING.md).

See [Contributing](CONTRIBUTING.md) for more information.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

FHIR&reg; is the registered trademark of HL7 and is used with the permission of HL7. 