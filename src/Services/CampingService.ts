import axios from "axios";
import ICamping from "src/Types/ICamping";

export default class ResultService {
  API_URL = process.env.VUE_APP_API_URL;
  public async getAllCampings(): Promise<ICamping[]> {
    const result = await axios.get(
      `${this.API_URL}/Owner/Campings/getAllCampings`
    );
    console.log(result);
    return result.data;
  }

  // public async addCamping(result: IResultRequest)
  // {
  //     let newResult: any = await axios.post(`${this.API_URL}/addResult/`, result);
  //     if (newResult.data != null)
  //         console.log(newResult.data);
  //     else
  //         console.log("error");
  //     return newResult.data;
  // }
}
