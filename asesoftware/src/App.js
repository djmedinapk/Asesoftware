import logo from './logo.svg';
import './App.css';
import { ThemeProvider } from '@material-ui/styles';
import theme from './Theme/Theme';
import TableUsers from './Containers/Table/TableUsers';

function App() {
  return (
    <ThemeProvider theme={theme}>
      <TableUsers/>
    </ThemeProvider>
  );
}

export default App;
