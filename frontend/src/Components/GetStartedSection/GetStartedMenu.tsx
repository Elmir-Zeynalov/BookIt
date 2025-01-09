import GetStartedMenuItem from "./GetStartedMenuItem";
import './GetStarted.css';

interface GetStartedMenuProps {
    className?: string;
}

function GetStartedMenu({ className }: GetStartedMenuProps) {
    return (
        <div className={className}>
            <GetStartedMenuItem
                className="get-started-menu-item"
                header="Create Account"
                description="Sign up and complete your profile to get started"
            />
            <GetStartedMenuItem
                className="get-started-menu-item"
                header="Connect on Instagram"
                description="Find a friend to introduce you via a group chat or DM us at @"
            />
            <GetStartedMenuItem
                className="get-started-menu-item"
                header="Get a Code"
                description="Your friend vouches for you, and we DM you a code."
            />
            <GetStartedMenuItem
                className="get-started-menu-item"
                header="Varify Account"
                description="Enter the code on the slide to verify your account."
            />
            <GetStartedMenuItem
                className="get-started-menu-item"
                header="Start Exploring"
                description="You're ready to look, list or book!"
            />
        </div>
    );
}
export default GetStartedMenu;