import { Controller, Get, Params, Response } from "@decorators/express"
import type { Response as RESTResponse } from "express"
import { Employee } from "src/models/Employee"

@Controller("/employees")
export class TicketsController {
    @Get("/:id")
    async getEmployee(@Response() res: RESTResponse, @Params("id") id: string) {
        try {
            const employee = await Employee.findById(id)
            console.log(employee)
            res.status(200).json(employee)
        } catch (err) {
            console.error(err)
            res.status(500).send("error")
        }
    }
}