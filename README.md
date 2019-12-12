# Full day mini-project in C# - Bumbler

Not quite Tumblr, but a web application that lets users read other user's bumbles and post their own that appear in a scrolling display. The only problem is that the lone Developer on the project bailed before finishing the complete solution and your manager says it's now up to you to finish the solution. The original developer only made progress on the backend, but at least you have some code to work with. You just have to figure out how to build the frontend and any enhancements.

* Implement the CRUD frontend components to manage Blunder posts using the *provided* backend web service. 
* Refer to the provided serverside code to extract the information you will need build the fully-functional frontend.
* Your stakeholder is hoping you make some enhancments to the current web service feature set as presently only basic CRUD for ```BlunderItems``` is supported.

### Page Details (Home/List, Blunder Add, Blunder Edit, Blunder Delete)
- Include a basic Navigation bar with a link to return to the Home Page on all pages.
- On Main Page, also include a button to Add a new item for sale as part of the navigation bar.
- On Main Page, list the list all the Blunder Posts in a single column down the page with the newest post at the top of the column. Display all properties for each entry. Below each post there should be options to Edit or Delete the Post,a Home option that will take them back to the top of the page, and an option to ```Like``` the post. When the user selects the ```Like``` option, it should update current like total by 1 (one)
- On Main Page, selecting ```Add Blunder``` should display a new page with a form that let's you add a Blunder post. After adding a post, return to the main listing page where the newly added Blunder should appear at the top of the list of posts.
- On Main Page, selecting ```Edit Blunder``` button should display the post details in an Edit form. After editing a post, return to the main listing page.
- On Main Page selecting ```Remove Blunder``` should display a confirmation box to confirm the removal. If acknowledged, delete the post. After deleting the post, return to the main listing page.
- Put some thought into how you will represents links to (buttons, images, other?) and implement a complete and consistent style for the site.

### NOTE: The backend service will start with an empty Blunder database when launched. Blunder posts are cleared from database  each time the server is shutdown.

### Challenges
- Don't require the user to enter their user name each time they make a post. Instead implement and enhancement that will prompt them for their user name, then retain it during the session and when creating posts (sort of a sudo login).
- Don't require the user to enter the date the post was created or updated each time they make a post. Instead implement and enhancement that will update the create/update date field automatically
- Add a search bar to top navigation where you can search by post title or post body (keyword search).
- Presently their is ony one topic supported. Figure out a way to to support different topics with their own Blunder posts and a way for the user to create and view them by topic.


