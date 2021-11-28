|Category    |Value|
|------------|-----|
|`Http Request`|GET|
|`URL`         |https://localhost:44310/api/Person|

### Example Response

```shell
{"id":"e694033f6a084492affdd851",
"firstName":"serdar",
"lastName":"serdar",
"company":"serdar",
"contacts":
  [
    {"contactId":"911c112ae8c74595b14ebb44",
    "id":"e694033f6a084492affdd851",
    "callNumber":45,
    "eMail":"serdar",
    "konum":"serdar",
    "bilgiİcerigi":"serdar"}
  ]
}
```

|Category    |Value|
|------------|-----|
|`Http Request`|POST|
|`URL`         |https://localhost:44310/api/Person|

### Example Value

```shell
{
  "firstName": "string",
  "lastName": "string",
  "company": "string",
  "contacts": [
    {
      "callNumber": 0,
      "eMail": "string",
      "konum": "string",
      "bilgiİcerigi": "string"
    }
  ]
}
```
|Category    |Value|
|------------|-----|
|`Http Request`|GET|
|`URL`         |https://localhost:44310/api/Person/{id}|

### Example Response

```shell
{
  "id":"e694033f6a084492affdd851",
  "firstName":"serdar",
  "lastName":"serdar",
  "company":"serdar",
  "contacts":
  [
    {
      "contactId":"911c112ae8c74595b14ebb44",
      "id":"e694033f6a084492affdd851",
      "callNumber":45,
      "eMail":"serdar",
      "konum":"serdar",
      "bilgiİcerigi":"serdar"
    }
  ]
}
```
|Category    |Value|
|------------|-----|
|`Http Request`|PUT|
|`URL`         |https://localhost:44310/api/Person/{id}|

### Example Value

```shell
{
  "firstName": "string",
  "lastName": "string",
  "company": "string",
  "contacts": [
    {
      "callNumber": 0,
      "eMail": "string",
      "konum": "string",
      "bilgiİcerigi": "string"
    }
  ]
}
```

|Category    |Value|
|------------|-----|
|`Http Request`|DELETE|
|`URL`         |https://localhost:44310/api/Person/{id}|

### Example Value
```shell
{
  "id":"e694033f6a084492affdd851"
}
```

|Category    |Value|
|------------|-----|
|`Http Request`|GET|
|`URL`         |https://localhost:44310/api/Contact/{Konum}|

### Example Value
```shell
{
  "Konum": "string"
}
```

|Category    |Value|
|------------|-----|
|`Http Request`|POST|
|`URL`         |https://localhost:44310/api/Contact|

### Example Value
```shell
{
  "callNumber": 0,
  "eMail": "string",
  "konum": "string",
  "bilgiİcerigi": "string"
}
```
