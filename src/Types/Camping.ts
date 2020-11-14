import Location from "@/Types/Location";
import Facilities from "@/Types/Facilities";

export default interface Camping {
  id: number;
  Owner: string;
  Name: string;
  Description: string;
  ParkingSize: number;
  ParkingType: number;
  Rating: number;
  PricePerDay: number;
  Location: Location;
  Facilities: Facilities;
  URL: URL;
}
