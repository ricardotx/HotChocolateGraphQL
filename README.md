# Dotnet API with Graphql using [ChilliCream GraphQL](https://github.com/ChilliCream/hotchocolate)
- Code-First approach.
- Code splitting.


## References
* [Building a basic GraphQL server API.](https://github.com/ChilliCream/graphql-workshop/blob/master/docs/1-creating-a-graphql-server-project.md)

## Packages
* [Pomelo.EntityFrameworkCore.MySql](https://www.nuget.org/packages/Pomelo.EntityFrameworkCore.MySql/5.0.0-alpha.2?_src=template)
* [Microsoft.EntityFrameworkCore.Tools](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools/5.0.1?_src=template)
* [HotChocolate.AspNetCore](https://www.nuget.org/packages/HotChocolate.AspNetCore/11.0.9?_src=template)

## Queries example

````graphql
# Get all Owners
{
  owners{
    id
    address
    name
    accounts {
      id
      description
      ownerId
      type
    }
  }
}

# Get one Owner
{
  owner(ownerId: "4c285165025a4f8c90360e95a26501e7"){
    id
    address
    name
    accounts {
      id
      description
      ownerId
      type
    }
  }
}

# Get all Accounts
{
  accounts {
    id
    type
    description
    ownerId
    owner {
      id
      address
      name
    }
  }
}
````

## Mutations example

````graphql
# Create an Owner
mutation ownerCreate {
  ownerCreate(data: { name: "New owner", address: "owner address" }) {
    id
    name
    address
    accounts {
      id
      description
      ownerId
      type
    }
  }
}

# Update an Owner
mutation ownerUpdate {
  ownerUpdate(
    ownerId: "1d4a952648194b58a06e05e853b02e16"
    data: { name: "Update owner", address: "update address" }
  ) {
    id
    name
    address
    accounts {
      id
      description
      ownerId
      type
    }
  }
}

# Delete an Owner
mutation ownerDelete {
  ownerDelete(ownerId: "1d4a952648194b58a06e05e853b02e16")
}
````
