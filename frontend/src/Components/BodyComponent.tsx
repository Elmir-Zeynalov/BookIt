import GetStartedComponent from "./GetStartedComponent";
import HeroComponent from "./HeroComponent";
import NavBar from "./NavBar";

function BodyComponent() {
  return (
      <>
          <NavBar />
          <HeroComponent />
          <GetStartedComponent/>
          
      </>
  );
}

export default BodyComponent;