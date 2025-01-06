import Accordion from 'react-bootstrap/Accordion';
import './GetStarted.css';
import GetStartedMenu from './GetStartedMenu';

function GetStartedComponent() {
    return (
        <Accordion className="get-started-guide">
            <Accordion.Item eventKey="0">
                <Accordion.Header>How to Get Started?</Accordion.Header>
                <Accordion.Body>
                    <GetStartedMenu className="get-started-menu">

                    </GetStartedMenu>
                </Accordion.Body>
            </Accordion.Item>
        </Accordion>
  );
}

export default GetStartedComponent;