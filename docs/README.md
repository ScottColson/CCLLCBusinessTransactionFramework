The Business Transaction Framework for CDS (BTF for short) is starting point to build 
complex business processes on top of the Microsoft PowerApps and the CDS platform. 

### History 

In 2016 I was fortunate to get hired as the CRM Architect for a complex 
Dynamics 365 CRM implementation that would be used by a Department of Motor Vehicles
to issue and manage drivers licenses and vehicle registrations. 

In 2018 I decided to leave the project and [Subrat Gaur](https://www.linkedin.com/in/subratgaur/) was hired
as my replacement. During our turnover sessions Subrat shared many ideas from his experience on similar projects. 
Subrat deserves much credit for the contents of this open source initiative which is based on an evolution of both
of our approaches to enacting complex business processes. 

For my 2016 DMV project we settled on an architecture that used used "transactional entities" to 
capture input data for processes that ultimately ended in the creation of variuos types of credentials
such as a drivers license. These transactional entities were linked to financal transacitons where we
caputured the fees that were collected and utlimately collected payment. 

We also used a validation framework that validated a set of requirements at key points in the process 
and at the end of the process prior to collecting payment. I have long been a fan of using this type of
system that allows waivable requirements to be specified outside of the bounds of the process. This particular
implementation allowed process implementors to call CRM Action processes to complete a validation and 
also allowed developers to create specific coded verifications that were activated via .NET Reflection 
when needed.

We used standard CRM workflows and action processes enhanced by coded workflow activities and plugins 
to enact or processes.

The architecture was solid and served us well but it had some major flaws:

1. Each new "transaction" had to be linked into both the financial framework and the validation framework.
2. The only natural way to kick off a process was by updating the transaction record which created some odd user experience situations.
3. There was very little reuse of process steps because they work created specific to a particular "transaciton entity".
4. Providing a consolidate list of Work In Progress (WIP) was complex because the list had to span multiple entity types. 
5. Part of the financial implementation was based on a custom CRM activity type which led to issues in UX and security role management.

### New Approach

This evolved architecture makes a single Transaction entity the center of the system. Each created Transaction has the following key features:

1. Linked to a specific customer which can be either an Account or a Contact.
2. Linked to a [Transaction Type](docs/Transaction Type.md) definition that defines requirements and processes for completing the transaction.
3. Linked to a starting Context Record (the record where the transacion was initiated.) 
4. Linked to a Data Capture Record used for capturing user input and providing the user experience.
5. Linked to a set of process history steps that captures when a particular process step was completed and information about the Agent and related Work Session at that time.
6. Linked to a set of Evidence collected during the execution of the transaction process. Evidence can be either collected authoratative documents or API interactions with external systems.
7. Linked to a set of Deficiencies that document the falure to meet requirements defined for the transaction type.
7. Linked to a set of Fees that will be charged to complete the transaction.
8. Linked to any Data Of Record that was created as part of the transaction process.

### Layerd Architecture

The system consists of the following modules that provide layers of functionality that stack to provide an overall framework:

- The **Platform Module** provides code interfaces and related data structures to manage users, channels, roles etc. as well as some key components that support deferred implementation of coded components that rely on meta data stored in the BTF system.

- The **Revenue Module** provides the functionality and data storage related to tracking revenue generation including defining fees, capturing payment, and providing a journal of financial activity in the system. 

- The **Documents Module** contains functionality to store authoratative documents captured as part of a process and to store documents created by the process. These are documents ar transaciton and process specific and by no means in the functionality intended to replace a document management system.

- The **Process Module** provides the functionality to define Transaction Types and to define complex synchronus Processes to complete a transaction. Processes are build from a series of reusable step types that include user interaction and data capture, conditional branching and various function specific tasks. System users can navigate the process forwards or backwards as needed. New step types can be added to the system as needed.

Within each of these modules the architecture is further broken up into the following slices:

- **Business logic** code that implements the core functions of the system and are independent of the CDS platform. This results in a better overall design that allows portability to other data platforms as well as the ability to implement on a different set of CDS entities if required.

- **Data layer** code that provides business logic the access it needs to the CDS data structures.

- **CDS Plugins** that allow CDS Actions to initiate Business Logic.

- **CDS Solutions** that combine Plugins, CDS Actions, CDS Entities and supporting web resources into a deployable managed solution.

### A Work In Progress

This framework is far from complete. Currently the Platform Module and Process Module are fairly robust but many Step Types still need to be implemented. The Revenue Module and Document Modules are mostly scaffolding at this point.