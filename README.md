# Setup
---
## [Auth0](https://auth0.com)
- Auth0 is free for basic usage.
- [Open Web Interface [OWIN]](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/owin)

### [Create Auth0 Application](https://manage.auth0.com/dashboard)
1. On the Auth0 Dashboard, select `Applications > Applications` from the side navigation panel
1. Select `Create Application`
1. Enter a valid name, such as `Primary API`
1. Choose the `Regular Web Applications` application type
1. TODO Configure URIs
	1. Callback: Where users are redirected after logging in
	1. Logout: Where users are redirected after logging out



### [Application](https://auth0.com/docs/quickstart/webapp/aspnet-owin/interactive)



---
## AWS
**Region:** `ap-southeast-2` Asia Pacific (Sydney)

### Root Account Creation
Root Accounts require a valid Credit Card, Mobile Number, and Email Address to complete account creation.

A digital card provider such as [Wise](https://wise.com) can be used to limit potential spending.

### Identity & Access Management (IAM)
In the `Search` box at the top of the AWS page, enter `IAM` and select the first result:
- [AWS IAM](https://us-east-1.console.aws.amazon.com/iam/home?region=ap-southeast-2)

#### Multi-Factor Authentication (MFA)
Under the `Security recommendations` section of the `IAM Dashboard`, follow the instructions to enable Multi-Factor Authentication (MFA).

#### Users: Admin
1. From the navigation panel on the left of the IAM page, under `Access management`, select `Users`
1. Select `Create user`
1. Name the user `Admin`
1. Check the box labeled `Provide user access to the AWS Management Console`
1. Select `I want to create an IAM user`
1. Select or provide a password
1. **[Optional]** Require the password be reset upon new login
1. Click `Next`
1. Click `Create group`
1. Name the group `Administrators`
1. Select the `AdministratorAccess` policy
1. Click `Create user group`
1. Select the `Administrators` group
1. Click `Next`
1. Click `Create user`

