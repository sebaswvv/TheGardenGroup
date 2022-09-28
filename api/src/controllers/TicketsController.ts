import { Controller, Get, Params, Patch, Post, Response, Delete, Request, Query } from "@decorators/express"
import type { query, Request as RESTRequest, Response as RESTResponse } from "express"
import { Status, Ticket } from "src/models/Ticket"

@Controller("/tickets")
export class TicketsController {    
    // get ticket by ticket id
    @Get("/:id")
    async getTicket(@Response() res: RESTResponse, @Params("id") id: string) {
        try {
            const ticket = await Ticket.findById(id)
            res.status(200).json({
                message: "success",
                ticket,
            })
        } catch (err) {            
            res.status(500).send({
                message: "error",
                description: "Sorry, we couldn't find a ticket with that ID",
            })
        }
    }

    // get all tickets
    @Get("/")
    async getTickets(@Response() res: RESTResponse, @Query() query) {
        try {     
            // build a new query for security purposes
            const newQuery = {}
            if (query.Status) newQuery["Status"] = query.Status
            if (query.Priority) newQuery["Priority"] = query.Priority
            if (query.EmployeeID) newQuery["EmployeeID"] = query.EmployeeID 
            if (query.Deadline) newQuery["Deadline"] = query.Deadline                                

            let tickets
            query ? tickets = await Ticket.find(newQuery) : tickets = await Ticket.find()            
            res.status(200).json({
                message: "success",
                amount: tickets.length,
                tickets,
            })
            res.send("hello")
                                         
        } catch (err) {
            console.error(err)
            res.status(500).send("error")
        }
    }

    // create a new ticket
    @Post("/")
    async createTicket(@Response() res: RESTResponse, @Request() request: any) {
        try {
            const ticket = new Ticket(request.body)
            ticket.save()
            res.status(200).json({
                message: "success",
                ticket,
            })
        } catch (err) {
            console.error(err)
            res.status(500).send("error")
        }
    }

    // update a ticket
    @Patch("/:id")
    async updateTicket(@Response() res: RESTResponse, @Params("id") id: string, @Request() request: any) {
        try {
            const ticket = await Ticket.findByIdAndUpdate(id, request.body, { new: true })
            res.status(200).json({
                message: "success",
                ticket,
            })
        } catch (err) {
            console.error(err)
            res.status(500).send("error")
        }
    }

    // delete a ticket
    @Delete("/:id")
    async deleteTicket(@Response() res: RESTResponse, @Params("id") id: string) {
        try {
            await Ticket.findByIdAndDelete(id)
            res.status(200).json({
                message: "successfully deleted ticket",
            })
        } catch (err) {
            console.error(err)
            res.status(500).send("error")
        }
    }
}

