# a connection to a Dynamics 365 Online deployment
# update the values as appropriate

# uncomment this when connecting to Dynamics 365 v9.x to ensure TLS 1.2 is used
[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12

@{
    OrganizationName = "org8763cfda" # see Settings > Customizations > Developer Resources > "Unique Name"
    ServerUrl = "https://orge83f40b7.crm.dynamics.com" # the online organization URL
    Credential = (Get-Credential) # prompt for credentials
}