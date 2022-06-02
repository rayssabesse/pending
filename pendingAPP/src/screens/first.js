import React, { Component } from 'react';
import {
    StyleSheet,
    Text,
    TouchableOpacity,
    View,
    Image,
} from 'react-native';

export default class First extends Component {


    render() {

        // Text Input - Don't change
        const loginTextInput = () => {
            const [number, onChangeNumber] = React.useState(null);
        }

        return (
            <View style={styles.main}>
                <View style={styles.container_header}>

                    <View style={styles.container_header_image}>
                        <Image source={require('../assets/pendingFirst.png')} />
                    </View>
                </View>

                <View style={styles.container_Images}>
                    <View style={styles.container_image}>
                        <Image source={require('../assets/Card.png')} />
                    </View>

                    <View style={styles.container_image_first}>
                        <Image source={require('../assets/DescriptionSign.png')} />
                    </View>
                </View>

                <View style={styles.container_bottom}>
                    <TouchableOpacity
                        style={styles.btnLogin}
                        onPress={() => this.props.navigation.navigate('Login')}>
                        <Text style={styles.btnLogin_text}>Entrar</Text>
                    </TouchableOpacity>

                    <View style={styles.container_bottom2}>
                        <View>
                            <Image source={require('../assets/Group.png')} />
                        </View>

                        <View >
                            <TouchableOpacity
                                onPress={() => this.props.navigation.navigate('SignUp')}>
                                <Text style={styles.signUp_text}>Cadastrar</Text>
                            </TouchableOpacity>
                        </View>
                    </View>
                </View>
            </View>
        );
    }
}

const styles = StyleSheet.create({
    main: {
        flex: 1,
        backgroundColor: '#242526',
    },

    container_bottom: {
        width: '100%',
        height: 'auto',
        alignSelf: 'center',
        alignItems: 'center',
        flex: 1,
        justifyContent: 'flex-end',
        marginBottom: 20,
    },
    container_header: {
        width: '100%',
        height: 'auto',
        alignSelf: 'center',
        alignItems: 'center',
        flexDirection: 'row',
        justifyContent: 'space-between',
    },

    container_header_image: {
        marginLeft: 35,
        marginTop: 30,
    },

    container_Images: {
        height: 40,
        marginBottom: 125,
        marginLeft: 100,
        alignSelf: 'center',
        alignItems: 'center',
    },

    container_image_first: {
        marginBottom: 100,
        marginRight: 100,
    },

    container_bottom2: {
        width: '80%',
        height: 'auto',
        alignSelf: 'center',
        alignItems: 'center',
        flexDirection: 'row',
        justifyContent: 'space-between',
        marginTop: 20,
    },

    signUp_text: {
        fontSize: 17,
        color: '#fff',
    },

    btnLogin: {
        height: 55,
        width: 345,
        backgroundColor: 'white',
        alignItems: 'center',
        justifyContent: 'center',
        borderRadius: 20,
        marginTop: 30,
    },

    btnLogin_text: {
        fontSize: 20,
        fontWeight: 'bold',
        color: '#222222',
    }

});