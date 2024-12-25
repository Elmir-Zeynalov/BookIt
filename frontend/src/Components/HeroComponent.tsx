import HeroSVG from '../Images/download.svg';


function HeroComponent() {
  return (
      <div>
          <img src={HeroSVG} alt="HeroSVG" width="1100" height="400" style={{ borderRadius: '30px' }} />
      </div>
  );
}

export default HeroComponent;