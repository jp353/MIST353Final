# MIST353 Final Peculiar Penguins (WeatherZone)

# Deployment Guide

This guide will walk you through the steps to deploy our application on a blank VM.

## Steps:
1. Clone the repository.
2. Create the database.
3. Open the solution.
4. Select the appropriate startup project(s).
5. Run the solution.

## Pitfalls to Avoid:
- Don't forget to select the startup project.
- Ensure the database is created on your VM.
- Make sure the bootstrap is downloaded.
- Ensure your host address matches your VM for linking purposes.

## Where to Go for Help:
- Office hours
- ChatGPT
- W3 Schools

# API Documentation: 

## API 1: PostSub - Kayla Guyton
- This API adds the chosen subcription (Enterprise) to the cart via the Enterprise "Add to Cart" button on the Subscription page.
- **Inputs:** SubID, Price, CartID (Manually Coded), CDate (Manually Coded)
- **Outputs:** Adds above inputs to user cart to be used in conjunction with API #2, CartService. Intended to add subscription details to the cart.
- **How to Use:** Click on the "Add to Cart" button under the Enterprise subscription Type on the Subscription Page.

## API 2: CartService - Kayla Guyton
- This API allows the user to check the progress their cart while visiting the webpage.
- **Inputs:** CartID
- **Outputs:** Allow the previous cart information to view the information that was ideally added within another API (not created) that would have created the cart. This allows them to view the cart through their time on the website. 
- **How to Use:** Click on the cart button on the HomePage. This feature has not been implentented but ideally this is what would happen if more time allowed.

## API 3: GetClimateData - John Pino
- This API allows the user to view the climate data related to a specified region.
- **Inputs:** RNum
- **Outputs:** Allows the user to view all data in the ClimateEvent table associated with the RNum they specified. The RNum is a foreign key from the Region table, which stores attributes for each region.  
- **How to Use:** Click on one of the 4 labelled buttons on the HomePage and select the corresponding region.
  
## API 4: LeaveFeedback - John Pino
- This API allows the user to leave feedback based on their experiences with the Weather Zone service.
- **Inputs:** RScore, RComment, RID (Auto-Increments)
- **Outputs:** Allows the user to insert feedback into the database. Users can insert a comment within a limited number of characters and a score from 1 to 10 to rate their overall satisfaction with the service.
- **How to Use:** Click on the Add Feedback button on the Feedback page. This feature is not yet integrated with JavaScript functionality on the webpage.
## API 5: PostSub - Hunter Latterner
- This API allows an admin to search current users of the website.
- **Inputs:** UID.
- **Outputs:** Allows an admin to read all user data including User First Name, User Last Name, User Password, and User Email.
- **How to Use:** Click the "Get User Data" button under the user page.
  ## API 6: - Hunter Latterner
- This API allows and admin to add a user to the webpage.
- **Inputs:** UID, UFName, ULName, UPassword, UEmail.
- **Outputs:** A new user is added to the webpage/database.
- **How to Use:** Click on the "Add User" button under the user page and add the users information.

# Application Overview

Our application provides a data organizing tool for insurance actuaries to sort weather data for client presentations. It also allows everyday users to easily view local weather data. Our goal is to generate revenue through a subscription-based platform. Key features include data retrieval, user feedback, user management, cart functionality, and subscription management.

# Developer Documentation

If a new group of developers were to take over our application, they would need to know:
- All necessary materials to clone the repository and database are located in our GitHub repository. DB file is located within DB branch, not master. 
- Follow the deployment steps outlined above to set up the application on a new VM.

# Webpage Documentation

## Page 1: Home Page
### Created by John Pino
The Home page will be the first page shown when you visit our website. It will contain information and the purpose of our company, show our company logo, navigation menu to help explore the site, and a demo of our subcription to give an idea of what our cite entails. The demo will be a representative view of a United States map seperated into 4 regions based on temperature and weather data. It will encourage visitors to explore further of our application!

The application will access the public NOAA climate API to retrieve climate data and insert it into the database. The API associated with the stored procedure spSearchClimateData, however, will be responsible for accessing the app's database and displaying information to the user based on their specifications. 

## Page 2: Privacy Policy Page
### Created by Hunter Latterner
The Privacy Policy page will allow users to read our privacy policy. The privacy policy will outline how our company collects, uses, discloses, and safeguards user information when using services or interacting with our site. Users can accept the privacy policy by checking the "I accept" box at the bottom of the policy.

## Page 3: Checkout Webpage
### Created by Kayla Guyton
### Intended to use CartServce API. API does work via Swagger, but it not implemented via Razor Page
The Checkout page will be where customers start, edit, and finalize their purchases. The checkout process will have the ability to enter personal details, choose the type of subsciption that best suits them and shipping options, entering payment information, and confirming the purchase. It's designed to be user-friendly and secure.

## Page 4: Subscription Page 
### Created by Kayla Guyton
### Implements PostSub API via Enterprise "Add to Cart" button
The Subscription page allows users to add a subscription to their cart based on a short, preset list of subscription options. This will initiate the checkout process, allowing users to select a subscription by clicking an "Add to Cart" button. The button will trigger an API call to the spCartAddSubscription stored procedure, which adds the selected subscription to their cart. This interaction seamlessly integrates with the backend system, allowing users to initiate the checkout process for the selected subscription product.

## Page 5: Feedback Page
### Created by John Pino
The Feedback page will allow users to leave their thoughts and experience. Users can access the page to view others reviews and can leave their own feedback by clicking "Leave Review". This will allow users to comment on their experience and also leave a rating of 1-5. It is designed to be very user-friendly and also can help us understand how different users experience our page.

## Page 6: UserData Page
### Created by Hunter Latterner
The UserData page serves as a platform for managing account-related information. Users can access this page to view and edit their personal details, such as name, email address, password, and any other relevant information associated with their account. 

Unlike the Subscription page, the UserData page does not utilize an API for data retrieval or manipulation. Instead, it interacts directly with the database to fetch and update user data, leveraging traditional database operations without the need for intermediary APIs. Users can interact with input fields and buttons to modify their account information, with changes being reflected immediately upon submission. This page provides users with a centralized location to manage their account details, enhancing their overall experience with the platform.

## References
 ChatGPT Prompt 1: Please modify this to achieve the functionality of the following stored procedure: (I input SPSearchClimateData and Climate Controller)
 
 Prompt 2: Please remove syntax errors from the following: (I input Climate Controller)
 
 Prompt 3: Please remove syntax errors from the following: (I input Feedback Controller)
 
 Prompt 4: Used to write mock descriptions for paragraphs on both home page and subscription page. 
