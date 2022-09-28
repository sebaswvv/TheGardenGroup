import { Controller, Get, Params, Patch, Post, Request, Response, Delete } from "@decorators/express"
import type { Response as RESTResponse } from "express"
import { Ticket } from "src/models/Ticket"

@Controller("/tickets")
export class TicketsController {  
    // get ticket by ticket id
    @Get("/:id")
    async getEmployee(@Response() res: RESTResponse, @Params("id") id: string) {
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
    async getEmployees(@Response() res: RESTResponse) {
        try {
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
    async addEmployee(@Response() res: RESTResponse, @Request() request: any) {
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
    async updateEmployee(@Response() res: RESTResponse, @Params("id") id: string, @Request() request: any) {
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
    async deleteEmployee(@Response() res: RESTResponse, @Params("id") id: string) {
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

