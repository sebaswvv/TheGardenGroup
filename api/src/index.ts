import { attachControllers } from "@decorators/express"
import { config } from "dotenv"
import express from "express"
import { connect } from "mongoose"
import { EmployeesController } from "./controllers/EmployeesController"
import { TicketsController } from "./controllers/TicketsController"

config()

const PORT = 2002
const app = express()
app.use(express.json())

run().catch(err => console.error("Error while trying to connect to database:", err))

async function run() {
    await connect(process.env.MONGODB_STRING, { dbName: "Main" })
}

attachControllers(app, [EmployeesController, TicketsController])

app.listen(PORT, () => {
    console.log(`Listening on port: ${PORT}\nhttp://localhost:${PORT}`)
})