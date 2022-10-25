import { Schema, model } from "mongoose"

export enum Priority {
    Low,
    Normal,
    High,
}

export enum Deadline {
    SevenDays, 
    FourtheenDays, 
    TwentyEightDays, 
    SixMonths
}

export enum Status {
    Open, 
    Resolved, 
    Closed
}

export interface ITicket {
    EmployeeID?: string;
    DateReported: Date;
    Subject: string;
    Priority: Priority;
    Deadline: Deadline;
    Description: string;
    Status: Status;    
}

const ticketSchema = new Schema<ITicket>({
    EmployeeID: { type: String, required: true },
    DateReported: { type: Date, required: true },
    Subject: { type: String, required: true },
    Priority: { type: Number, required: true },
    Deadline: { type: Number, required: true },
    Description: { type: String, required: true },
    Status: { type: Number, required: true },       
}, { versionKey: false })

export const Ticket = model<ITicket>("tickets", ticketSchema)
