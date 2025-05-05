# Setup

## AWS
**Region:** `ap-southeast-2` Asia Pacific (Sydney)

### Identity & Access Management (IAM)
In the `Search` box at the top of the AWS page, enter `IAM` and select the first result:
- [AWS IAM](https://us-east-1.console.aws.amazon.com/iam/home?region=ap-southeast-2)

#### Multi-Factor Authentication (MFA)
Under the `Security recommendations` section of the `IAM Dashboard`, follow the instructions to enable Multi-Factor Authentication (MFA).

#### Users: Admin
1. From the navigation panel on the left of the IAM page, under `Access management`, select `Users`
2. Select `Create user`
3. Name the user `Admin`
4. Check the box labeled `Provide user access to the AWS Management Console`
5. Select `I want to create an IAM user`
6. Select or provide a password
7. **[Optional]** Require the password be reset upon new login
8. Click `Next`
9. Click `Create group`
10. Name the group `Administrators`
11. Select the `AdministratorAccess` policy
12. Click `Create user group`
13. Select the `Administrators` group
14. Click `Next`
15. Click `Create user`
