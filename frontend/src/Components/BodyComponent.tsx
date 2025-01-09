
import GetStartedComponent from "./GetStartedSection/GetStartedComponent";
import HeroComponent from "./HeroComponent";
import SectionHeader from "./SectionHeader";
import NavBar from "./NavBar";
import PropertiesSection from "./Properties/PropertiesSection";
import { Property } from "./Properties/types";





function BodyComponent() {

    const exampleProperties: Property[] = [
        {
            apartmentName: "Oceanview Apartment",
            apartmentLocation: "Miami, FL",
            leasing: "Short-Term",
            fromDate: "2025-01-10",
            toDate: "2025-01-20",
            pricePerNight: 150,
            pricePerMonth: 4000,
            url: "https://example.com/oceanview",
        },
        {
            apartmentName: "City Center Loft",
            apartmentLocation: "New York, NY",
            leasing: "Monthly",
            fromDate: "2025-02-01",
            toDate: "2025-02-28",
            pricePerNight: 200,
            pricePerMonth: 6000,
            url: "https://example.com/citycenter",
        },
        {
            apartmentName: "City Center dfasdfasdfasd",
            apartmentLocation: "New York, NY",
            leasing: "dfa",
            fromDate: "2025-02-01",
            toDate: "2025-02-28",
            pricePerNight: 200,
            pricePerMonth: 6000,
            url: "https://examplasdfasde.com/citycenter",
        },
        {
            apartmentName: "City Corner",
            apartmentLocation: "Barbados, NY",
            leasing: "Daily",
            fromDate: "2025-02-01",
            toDate: "2025-02-28",
            pricePerNight: 20000,
            pricePerMonth: 9000,
            url: "https://examplsssse.com/citycenter",
        },
    ];

    return (
        <>
            <NavBar />
            <HeroComponent />
            <GetStartedComponent />
            <SectionHeader text="Listings by Borough" />
            <PropertiesSection propertyTitle="Manhattan Properties" properties={exampleProperties} />

            {/* <PropertiesSection propertyTitle="Brooklyn Properties"  />
            <PropertiesSection propertyTitle="Bronx Properties"  />
            <PropertiesSection propertyTitle="Queens Properties"  />
            <PropertiesSection propertyTitle="Staten Island Properties Properties" />
            */
            }
        </>
    );
}

export default BodyComponent;