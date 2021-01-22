## 2. Back-end

### Problem statement

In a small Asp .NET Core system using EntityFramework you have a model that defines an entity `Todo`. With fields `TodoId, Description, Status , concurrencyToken`.  The `TodoId` is of type `Guid` and used as primary key on the Todo table. 

For any update a requester must pass an updated `concurrencyToken` otherwise the controller `TodoController` responds with a 409 Conflict response indicating that the entity has changed since the requester loaded it, possibly by another user.

### Task description

Your task is simply to implement a working example of this small system. Specifically, there must be an endpoint that accepts a list of TodoIds along with their associated `concurrencyTokens` and updates the `Status` on the corresponding entries in your database to done. If any `Todo` are attempted to be updated where the `concurrencyToken` does not match. Then the entire update operation must be rolled back and the response should be as described above.

What is the purpose? 
To avoid A concurrency conflict. This occurs when one user displays an entity's data in order to edit it, and then another user updates the same entity's data before the first user's change is written to the database. If we don't enable the detection of such conflicts, whoever updates the database last overwrites the other user's changes. In many applications, this risk is acceptable: if there are few users, or few updates, or if isn't really critical if some changes are overwritten, the cost of programming for concurrency might outweigh the benefit. In that case, we don't have to configure the application to handle concurrency conflicts.
