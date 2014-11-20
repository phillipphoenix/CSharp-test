# Design a database

Construct a schema that solves the following problem.

> Design a schema for a web shop. The shop has an inventory of products, each item has a price but depending on sales this price can vary.
> Customers can make an order for multiple items at a time and want to be able to see their order history as it was at the time of ordering.
> When the order has been completed an optional track and trace number can be attached to the package.

Make it simple to work with while also keeping performance in mind.

Use the Model1.edmx file to model your schema.

If you're familiar with Entity Framework Code First then feel free to use that approach. (Just the domain classes, no need for a DbContext class)