type GetStartedMenuItemDescriptionProps = {
    description: string;
};
function GetStartedMenuItemDescription({ description }: GetStartedMenuItemDescriptionProps) {
    return (
        <p>{description}</p>
    );
}

export default GetStartedMenuItemDescription;