import { model, Schema } from "mongoose"

export enum Location {
    Haarlem,
    Amsterdam,
    Knuppeldam,
    HaarlemHQ,
}

export interface IEmployee {
    FirstName: string;
    LastName: string;
    Email: string;
    Password?: string;
    PhoneNumber: string;
    Location: Location;
    IsServiceDeskEmployee: boolean;
}

const employeeSchema = new Schema<IEmployee>({
    FirstName: { type: String, required: true },
    LastName: { type: String, required: true },
    Email: { type: String, required: true },
    Password: { type: String, required: true },
    PhoneNumber: { type: String, required: true },
    Location: { type: Number, required: true, enum: Location },
    IsServiceDeskEmployee: { type: Boolean, required: true },
}, { versionKey: false })

export const Employee = model<IEmployee>("employees", employeeSchema)