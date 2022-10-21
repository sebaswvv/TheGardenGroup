# API server

To start the API server:

1. `cd api`
2. `npm install`
3. `npm start`
4. The server will be hosted at http://localhost:2002/

---

## Tickets api: /tickets

### Ticket object

| Property     | Type   |
|--------------|--------|
| EmployeeID   | string |
| DateReported | Date   |
| Subject      | string |
| Priority     | number |
| Deadline     | number |
| Description  | number |
| Status       | number |

### Get all tickets
GET `/tickets`

To search through all tickets, there are 4 possible search queries;
- `Status`
- `Priority`
- `EmployeeID`
- `Deadline`

These options can be used together.

For example: GET `/tickets?EmployeeID=6343f78fad46311ee75b5de3&Status=0`

Returns an array of [Ticket](#ticket-object) objects.

### Get a specific ticket

GET `/tickets/:id`

Returns a [Ticket](#ticket-object) object.

### Delete a specific ticket

DELETE `/tickets/:id`

Returns a [Ticket](#ticket-object) object.

### Edit a specific ticket

PATCH `/tickets/:id`

Body: `Ticket` object

Returns a [Ticket](#ticket-object) object.

### Create a new ticket

POST `/tickets`

Body: `Ticket` object

Returns a [Ticket](#ticket-object) object.

---

## Employees api: /employees

### Employee object

| Property              | Type    |
|-----------------------|---------|
| FirstName             | string  |
| LastName              | string  |
| Email                 | string  |
| Password              | string  |
| PhoneNumber           | string  |
| Location              | number  |
| IsServiceDeskEmployee | boolean |

### Get all employees
GET `/employees`

Returns an array of [Employee](#employee-object) objects.

### Get an employee

GET `/employees/:id`

Returns an [Employee](#employee-object) object.

### Edit an employee

PATCH `/employees/:id`

Body: [Employee](#employee-object) object

Returns the updated [Employee](#employee-object) object.

### Create a new employee

POST `/employees`

Body: [Employee](#employee-object) object.

Returns an [Employee](#employee-object) object.

### Delete an employee

DELETE `/employees/:id`

Returns the deleted [Employee](#employee-object) object.
