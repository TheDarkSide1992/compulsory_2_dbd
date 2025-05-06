# Compulsory_2_dbd
This is a school project at EASV purely based on architectural design for an e-commerce application.

## by
* Jens
* Emil
* Andreas

## Desciption
There are a lot of considerations to be made with data storage and management of data like what kind of databases to use, where to store images and how the software handles the data, as well as the overall architecture of the application.

To store user and order information there were a lot of options, but we decided on using a relational database, like mssql since it is data that does not change often. 

For listings and reviews of sellers we chose another solution, since they can benefit greatly from the use of a no sql database like mongodb. Mongodb is a good option, due to its fast read speed and is easily scalable, together with its flexible schema, that allows for faster accessing of data. 

Implementing a cache would save a few read calls to our database, therefore it would be a good idea to store listings and reviews of a seller in a redis cache, since they are likely to get accessed a lot more frequently by users.
When a listing or review of a seller has been updated, or after a specific amount of time passes the cache should be invalidated, since the data can be out of date from what is stored in the database.

Storing of media files like images should be done with a cloud storage provider. This can be achieved by using MinIO to store the media files.  We do still need to store the metadata related to the MinIO storage within our own database so we still can access it later. This metadata could be stored within our MongoDB database schema. This would hold the media files object_key, that references the media file in MinIO.

We could implement CQRS as a way to split up the read and write, since in a larger system the read and write operations often have different scaling and performance requirements. The traditional CRUD approach does not take this asymmetry into account, so in this system it might be a good idea to implement CQRS on listings and reviews, since these operations is likely to benefit from the CQRS approach. This benefit is because the operations for reading data would be executed more frequently than a create or update.

We also added an in-memory event bus, with events for the different commands. An example is when a listing or review changed event happens. There could be a CacheInvalidated event that invalidates the cache, when the event gets received.

When placing an order on the site it would be relevant to use a unit of work since the software needs to perform a sequence of actions. This could include an order being created, updates of a listing and a payment action is performed. In a large system like this there is a lot that could go wrong, two users trying to buy the same listing with only one product available at the same time, one or more of the operations were successful but one failed. The unit of work would make that process easier, since it can perform a transaction across multiple database calls. This results in a transaction where nothing gets saved if one of the calls fails. Unit of work also removes the concern of multiple users trying to buy the same listing with one product available at the same time.

We did consider taking inspiration from how mcmaster-carr’s website works, due to its extremely fast and very optimised read speed. If we were to go this route we would make the program able to generate static html pages for all the listings and store them in a cloud storage, since getting the static html files would be faster than having to fetch a lot of different data from multiple data sources. This would add a lot of complexity and there was not enough time to fully understand what was actually going on in this approach.

