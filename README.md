# martenChocolate
Initial attempt at marten (https://martendb.io/) and hotchocolate (https://chillicream.com/) integration.

To run the project:
1. Update settings in `appsettins.json` file to point to an existing instance of Postgres, or bring up an instance of Postgres with docker as follows:
``` docker-compose up```
2. Run the project
3. Query using the GraphQl UI at `http://localhost:3060/graphql`