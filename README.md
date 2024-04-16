# MIST353Project4

## Page 1: Home Page
### Created by John Pino
### The Home page will be the first page shown when you visit our website. It will contain information and the purpose of our company, show our company logo, navigation menu to help explore the site, and a demo of our subcription to give an idea of what our cite entails. The demo will be a representative view of a United States map seperated into 4 regions based on temperature and weather data. It will encourage visitors to explore further of our application!

### The application will access the public NOAA climate API to retrieve climate data and insert it into the database. The API associated with the stored procedure spSearchClimateData, however, will be responsible for accessing the app's database and displaying information to the user based on their specifications. 

## Page 2: Privacy Policy Page
### Created by Hunter Latner
### The Privacy Policy page will allow users to read our privacy policy. The privacy policy will outline how our company collects, uses, discloses, and safeguards user information when using services or interacting with our site. Users can accept the privacy policy by checking the "I accept" box at the bottom of the policy.

## Page 3: Checkout Webpage
### Created by Kayla Guyton
### Intended to use CartServce API. API does work via Swagger, but it not implemented via Razor Page
### The Checkout page will be where customers start, edit, and finalize their purchases. The checkout process will have the ability to enter personal details, choose the type of subsciption that best suits them and shipping options, entering payment information, and confirming the purchase. It's designed to be user-friendly and secure.

## Page 4: Subscription Page 
### Created by Kayla Guyton
### Implements PostSub API via Enterprise "Add to Cart" button
### The Subscription page allows users to add a subscription to their cart based on a short, preset list of subscription options. This will initiate the checkout process, allowing users to select a subscription by clicking an "Add to Cart" button. The button will trigger an API call to the spCartAddSubscription stored procedure, which adds the selected subscription to their cart. This interaction seamlessly integrates with the backend system, allowing users to initiate the checkout process for the selected subscription product.

## Page 5: Feedback Page
### Created by John Pino
###  The Feedback page will allow users to leave their thoughts and experience. Users can access the page to view others reviews and can leave their own feedback by clicking "Leave Review". This will allow users to comment on their experience and also leave a rating of 1-5. It is designed to be very user-friendly and also can help us understand how different users experience our page.

## Page 6: UserData Page
### Created by Hunter Latner
###  The UserData page serves as a platform for managing account-related information. Users can access this page to view and edit their personal details, such as name, email address, password, and any other relevant information associated with their account. Unlike the Subscription page, the UserData page does not utilize an API for data retrieval or manipulation. Instead, it interacts directly with the database to fetch and update user data, leveraging traditional database operations without the need for intermediary APIs. Users can interact with input fields and buttons to modify their account information, with changes being reflected immediately upon submission. This page provides users with a centralized location to manage their account details, enhancing their overall experience with the platform.

## References
### ChatGPT Prompt 1: Please modify this to achieve the functionality of the following stored procedure: (I input SPSearchClimateData and Climate Controller)
### Prompt 2: Please remove syntax errors from the following: (I input Climate Controller)
### Prompt 3: Please remove syntax errors from the following: (I input Feedback Controller)
### Prompt 4: Used to write mock descriptions for paragraphs on both home page and subscription page. 
