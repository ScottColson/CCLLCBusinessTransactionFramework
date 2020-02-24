# Business Transaction Framework for CDS

The Business Transaction Framework for CDS (BTF for short) is starting point to build 
complex business processes on top of the Microsoft PowerApps and the CDS platform. 

### History 

In 2016 I was hired as the CRM Architect for a complex Dynamics 365 CRM implementation that would 
be used by the Department of Motor Vehicles within the Idaho Transportation Department to issue and 
manage drivers licenses and vehicle registrations. 

For my DMV project we settled on an architecture that used "transactional entities" to 
capture input data for processes that ultimately ended in the creation of variuos types of credentials
such as a drivers license. These transactional entities were linked to financal transacitons where we
caputured the fees that were collected and utlimately collected payment prior to completing the transaction.

We used a validation framework that validated a set of requirements at key points in the process 
and at the end of the process prior to collecting payment. I have long been a fan of using this type of
system that allows waivable requirements to be specified outside of the bounds of the process. This particular
implementation allowed process implementors to call CRM Action processes to complete a validation and 
also allowed developers to create specific coded verifications that were activated via .NET Reflection 
when needed.

Whenever possible we used standard CRM workflow and action processes enhanced by coded workflow activities and plugins 
to enact or processes. The goal was to let process builders make the processes and let the codes write the code.

The architecture was solid and served us well but it had some flaws:

1. Each new "transaction" had to be linked into both the financial framework and the validation framework.
2. The only natural way to kick off a process was by updating the transaction record which created some odd user experience situations.
3. There was very little reuse of process steps because they work created specific to a particular "transaciton entity".
4. Providing a consolidate list of Work In Progress (WIP) was complex because the list had to span multiple entity types. 
5. Part of the financial implementation was based on a custom CRM activity type which led to issues in UX and security role management.
6. The use of CRM workflows made it possible to decouple process from code but it also resulted in an explosion of workflows that made it difficult to see understand the overall all process.

In 2018 I decided to leave the project and [Subrat Gaur](https://www.linkedin.com/in/subratgaur/) was hired
as my replacement. During our turnover sessions Subrat shared many ideas from his experience on similar projects. 
Subrat deserves much credit for the contents of this open source initiative which is an evolution of both
of our approaches to enacting complex business processes. 

### New Approach

This framework was born out of projects related to issuing driving credentials but my intent is to provide 
a starting point for creating a system to implement one or more complex multistep business process of any type. 
I've evaluated the kinds of problems I've addressed over my career of creating Line Of Business applications 
on top of the Dynamics CRM (aka PowerPlatorm) system and tried to make a framework that addresses the 
common situations I've run into. To that end, this framework addresses the common requirements.

- Managing Changes to Data Of Record - Most business processes result in creating a record or document that should not be modified without specific authority and auditability of the changes. In this framework that type of record is referred to as Data Of Record and changes to Data Of Record are completed via processes by people that are authorized to do so using defined processes with recorded history.

- Data Collection - Most processes require a user experience that invovles entering data that is used by the process. In this framework that is handled by a Data Capture Entity which provides the structure to capture the data and one or more forms to guide the user experience.
 
- Implementing Complex Processes - Complex problems have complex processes. This framwork provides a means to create reusable process steps. These steps provide branching capability, leveage existing CDS features such as Action processes, guide users through data entry, or execute coded implementations specific to a particular problem. Users navigate through the process in a series of Next and Back steps as needed until the process is completed.

- Understanding the Process Context - Many processes only make sense if they start from a specific record type. In this framework that is defined as the context and processes can only be initiated from records that meet initial context filters.

- Documenting Process History - It is always beneficial to understand who did what and when the did it. This framework provides history of every process step completed.

- Fee Collection - Business processes often involve establishing fees and collecting payment from customers. This framework provides the required scaffolding to manage fees, apply fees to transactions, and collect fee payment.

- Validating Requirements - The completion of a business process often involves ensuring a set of requirements have been met. In some cases requirements may be waived. This framework provides a validation engine that varifies defined requirements, documents any resulting deficiencies, and when needed supports role based waiving of specific requirements.

- Extensibility - We don't know what we don't know at the start of a project. Therefore the framework needs to be extensible allowing the addition of new types of process steps that solve the currently unknown problem.

### Business Transactions

This framework makes a single Transaction entity the center of the system. Each created Transaction has the following key features:

1. Linked to a specific customer which can be either an Account or a Contact.
2. Linked to a [Transaction Type](TransactionType.md) that defines requirements and the overall processes for completing the transaction.
3. Linked to a starting [Context Record](ContextRecord.md) (the record where the transacion was initiated.) 
4. Linked to a [Data Capture Record](DataCaptureRecord.md) used for capturing user input and providing the user experience.
5. Linked to a set of process history steps that captures when a particular process step was completed and information about the Agent and related Work Session at that time.
6. Linked to a set of Evidence collected during the execution of the transaction process. Evidence can be either collected authoratative documents or API interactions with external systems.
7. Linked to a set of Deficiencies that document the falure to meet requirements defined for the transaction type.
7. Linked to a set of Fees that will be charged to complete the transaction.
8. Linked to any Data Of Record that was created or modified as part of the transaction process.

### Process Definitions

Processes are defined for each type of transaction. These processes consist of a series of steps that rely on pre-created 
Step Types combined with meta data included in the specific process step definition. New types of steps can be created and registered
in the BTF for use in any process. The following types of steps are currently available or in development.

- Data Form - Displays a defined CDS form bound to the Data Capture Entity so users can enter data.
- Dialog Window - Displays a defined dialog form to the user and awaits user response.
- Execute Data Record Action - Runs a CDS Action bound to the transaction Data Capture Record.
- Execute Context Record Action - Runs a CDS Action bound to the transaction Context Record.
- Branch - Used defined logic evaluators to select one or more branches for a process.
- Set Process Backstop - Establishes process step that limits how far back a user can navigate a process.
- Add Fee - Adds a new fee to the list of applied fees for the transaction.
- Add To Cart - Adds a transaction to the customers check out cart.
- Wait for Checkout - Navigates the user to the checkout user form and then waits for the checkout process to complete.


### Deferred Implementation

Deferred Implementation provides a way to merge coded implementations with meta data stored in the BTF to 
complete an operation. This model allows developers to code extensions to the BTF that can be consumed by 
process creators. It analogous to creating Connectors for the PowerAutomate platform, however, deferred 
implementation components in the BTF operate synchronously within the sandboxed plugin process space.

Logic Evaluators are a specific type of Deferred Implementation that is used to interact with the CDS system 
or APIs to external systems to make simple true/false decisions that are used to validate requirements or 
select conditional branches within a process. 

Step Types are an additional type of Deferred Implementation that provide any required underlying code 
to complete a the intended implementation of the step. 


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
