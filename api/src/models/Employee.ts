import { model, Schema } from "mongoose"

export interface IEmployee {
    FirstName: string;
    LastName: string;
    Email: string;
    Password?: string;
    PhoneNumber: string;
    Location?: string;
}

const employeeSchema = new Schema<IEmployee>({
    FirstName: String,
    LastName: String,
    Email: String,
    Password: { type: String, required: false },
    PhoneNumber: String,
    Location: { type: String, required: false },
})

export const Employee = model<IEmployee>("employees", employeeSchema)