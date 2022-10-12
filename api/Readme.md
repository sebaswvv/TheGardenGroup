To start the API server. Open root folder in a terminal and type: npm start

Tickets api: /tickets

GET /tickets/ => to get all tickets
To search inside all tickets, there are 4 possible search query's;
Status,
Priority,
EmployeeID,
Deadline
These options can be used together

GET /tickets/:id => to get a specific ticket on ticketID

DEL /tickets/:id => to delete a specific ticket on ticketID

PATCH /tickets/:id => edit a specific ticket on ticketID

POST /tickets => post a new ticket

Employees api:
