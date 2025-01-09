
import { Property } from "./types";
import myImage from './0be04875-2131-49b7-ab6e-867378b82f32_IMG_1152.jpeg';

interface PropertyProps {
    className: string,
    propertyInfo: Property;
}


function PropertyCard({ className, propertyInfo }: PropertyProps) {
    return (
        <div style={{ border: "1px solid"}} >
            <div style={{ border: "1px solid", width: '250px', height: '200px', overflow: 'hidden' }}>
                <img
                    src={myImage}
                    alt="Italian Trulli"
                    style={{
                        width: '100%',
                        height: 'auto',
                        objectFit: 'contain',
                        maxWidth: '100%',
                        borderRadius: '10px',
                    }}
                />    
            </div>
            
            <h3>{propertyInfo.apartmentName}</h3>
            <p>{propertyInfo.apartmentLocation}</p>
            <p>{propertyInfo.leasing}</p>
            <p>{propertyInfo.fromDate} - {propertyInfo.toDate}</p>

        </div>
     
  );
}

export default PropertyCard;