import { Body, Controller, Delete, Get, Params, Patch, Post, Response } from "@decorators/express"
import type { Response as RESTResponse } from "express"
import { Employee, IEmployee } from "src/models/Employee"

@Controller("/employees")
export class EmployeesController {
    @Get("/:id")
    async getEmployee(@Response() res: RESTResponse, @Params("id") id: string) {
        try {
            const employee = await Employee.findById(id)
            console.log(employee)

            if (employee === null) {
                return res.status(404).json({
                    message: "Employee not found",
                })
            }

            res.status(200).json(employee)
        } catch (err) {
            console.error(err)
            res.status(500).json({
                message: "An error occured",
                error: err,
            })
        }
    }

    @Get("/")
    async getEmployees(@Response() res: RESTResponse) {
        try {
            const employees = await Employee.find()
            res.status(200).json(employees)
        } catch (err) {
            console.error(err)
            res.status(500).json({
                message: "An error occured",
                error: err,
            })
        }
    }

    @Post("/")
    async addEmployee(@Response() res: RESTResponse, @Body() body: IEmployee) {
        try {
            const employee = new Employee(body)
            await employee.save()
            res.status(201).json(employee)
        } catch (err) {
            console.error(err)
            res.status(500).json({
                message: "An error occured",
                error: err,
            })
        }
    }

    @Patch("/:id")
    async updateEmployee(@Response() res: RESTResponse, @Params("id") id: string, @Body() body: Partial<IEmployee>) {
        try {
            const employee = await Employee.findByIdAndUpdate(id, body, { new: true })
            if (employee === null) {
                return res.status(404).json({
                    message: "Employee not found",
                })
            }

            res.status(200).json(employee)
        } catch (err) {
            console.error(err)
            res.status(500).json({
                message: "An error occured",
                error: err,
            })
        }
    }

    @Delete("/:id")
    async deleteEmployee(@Response() res: RESTResponse, @Params("id") id: string) {
        try {
            const employee = await Employee.findByIdAndDelete(id)
            res.status(200).json(employee)
        } catch (err) {
            console.error(err)
            res.status(500).json({
                message: "An error occured",
                error: err,
            })
        }
    }
}