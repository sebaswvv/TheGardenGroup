import { Schema, model } from "mongoose"

export interface IEmployee {
    Name: string;
    Email?: string;
    Avatar?: string;
}

const employeeSchema = new Schema<IEmployee>({
    Name: { type: String, required: false },
    Email: { type: String, required: false },
    Avatar: String,
})

export const Employee = model<IEmployee>("Employees", employeeSchema)