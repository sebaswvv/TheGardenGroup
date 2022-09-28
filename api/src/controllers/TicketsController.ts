import { Controller, Get, Params, Patch, Post, Request, Response, Delete } from "@decorators/express"
import type { Response as RESTResponse } from "express"
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
            console.error(err)
            res.status(500).send("error")
        }
    }

    // get all tickets
    @Get("/")
    async getTickets(@Response() res: RESTResponse, @Request() req: any) {
        try {
            console.log(req.query)
            const tickets = await Ticket.find()
            res.status(200).json({
                message: "success",
                amout: tickets.length,
                tickets,
            })
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

