interface SectionHeaderProps {
    text: string;
}

function SectionHeader({ text }: SectionHeaderProps) {
    return (
        <h3 style={{ textAlign: "center" }}> {text} </h3>
  );
}

export default SectionHeader;