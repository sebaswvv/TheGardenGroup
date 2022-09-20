import { Body, Controller, Get, Params, Post, Request, Response } from "@decorators/express"
import type { Response as RESTResponse } from "express"
import { request } from "http"
import { Ticket } from "src/models/Ticket"

@Controller("/tickets")
export class TicketsController {
  @Get("/:id")
    async getEmployee(@Response() res: RESTResponse, @Params("id") id: string) {
        try {
            const ticket = await Ticket.findById(id)            
            res.status(200).json(ticket)
        } catch (err) {
            console.error(err)
            res.status(500).send("error")
        }
    }

   @Post("/")
  async updateEmployee(@Response() res: RESTResponse, @Request() request: any) {
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
}

