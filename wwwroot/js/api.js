class Api {
    constructor(name) {
        this.name = name;
    }

    // Create a new Bumbler post
    createBumbler(bumblerInstance) {
        console.log(`Creating a Bumbler post`);
    }
    
    // Retrieve an existing Bumbler post
    readBumbler(bumblerInstanceId) {
        console.log(`Reading Bumbler post ${bumblerInstanceId}`);
    } 
    
    // Get all the current Bumbler posts
    readBumblers() {
        console.log(`Reading all Bumbler posts`);
    } 

    // Update an existing Bumbler post
    updateBumbler(bumblerInstance) {
        console.log(`Updating a Bumbler post`);
    }

    // Remove an existing Bumbler post
    deleteBumbler(bumblerInstanceId) {
        console.log(`Deleting Bumbler post ${bumblerInstanceId}`);
    } 
    
    
    
}
export default Api;