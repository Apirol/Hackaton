import axios from "axios";
import Camping from "@/Types/Camping";

export default class ResultService {
  API_URL = process.env.VUE_APP_API_URL;
  public async getAllCampings(): Promise<Camping[]> {
    const result = await axios.get(
      `${this.API_URL}/Owner/Campings/getAllCampings`
    );
    console.log(result);
    return result.data;
  }

  public async addCamping(camping: Camping) {
    const newCamping: any = await axios.post(
      `${this.API_URL}/Owner/Campings/addCamping`,
      camping
    );
    if (newCamping.data != null) console.log(newCamping.data);
    else console.log("error");
    return newCamping.data;
  }

  public async getOwnersCamping(): Promise<Camping[]> {
    const campings: any = await axios.get(
      `${this.API_URL}/Owner/Campings/addCamping`
    );
    console.log(campings);
    return campings.data;
  }

  public async getSearchCampings(): Promise<Camping[]> {
    const campings: any = await axios.get(
      `${this.API_URL}/Owner/Campings/searchCampings`
    );
    console.log(campings);
    return campings.data;
  }
}
