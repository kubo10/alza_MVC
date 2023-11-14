
# Alza WebAPI

This is simple WebAPI project to demonstrate my knowledge of C# + .NET. Project is based on .NET 6 (last LTS version). 

## Features
Project is using :
- .NET 6
- Entity framework core (ORM)
- Swagger


## Prerequisites

```properties
Visual studio 
```

## Usage

First we need to clone repo. Use some IDE for that or Github CLI 
```properties
gh repo clone kubo10/alza_MVC
```
When we have our repo cloned we can open our solution(**Alza_MVC.sln**) by VS. 
We have 2 options how to run our app. This options are set in launchSettings.json


1.**Alza_WebAPI_SQL_Server** - This options works with database on SQL server. Connectionstring needs to be set in **appsettings.Development.json**.

2.**Alza_WebAPI_InMemoryDatabase** - This options is based on **InMemoryDatabase** so we not needed Connectionstring.

## API Reference

#### Get all items

```http
  GET /api/v1/Product/products
```

#### Get all items with pagination (page size is set to 10)

```http
  GET /api/v1/Product/products/{page}
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `page` | `int` | **Required**. Page number |


#### Get item

```http
  GET /api/v1/Product 
  GET /api/v2/Product 
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `productId`      | `Guid` | **Required**. Id of product to fetch |


Takes two numbers and returns the sum.

#### Update product description

```http
  PUT /api/v1/Product
  PUT /api/v2/Product
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `productId`      | `Guid` | **Required**. Id of product to update |
| `description`      | `string` | Description |