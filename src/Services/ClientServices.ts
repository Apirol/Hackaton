import axios from "axios";
import Client from "@/Types/Client";

export default class ResultService {
  API_URL = process.env.VUE_APP_API_URL;
  public async getAllClients(): Promise<Client[]> {
    const result = await axios.get(
      `${this.API_URL}/Owner/Clients/getAllClients`
    );
    console.log(result);
    return result.data;
  }

  public async addClient(Client: Client) {
    const newClient: any = await axios.post(
      `${this.API_URL}/Owner/Clients/addClient`,
      Client
    );
    if (newClient.data != null) console.log(newClient.data);
    else console.log("error");
    return newClient.data;
  }

  public async getClientById(): Promise<Client[]> {
    const Clients: any = await axios.get(
      `${this.API_URL}/Owner/Clients/getClient`
    );
    console.log(Clients);
    return Clients.data;
  }
}
