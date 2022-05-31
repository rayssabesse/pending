import React, { Component } from 'react';
import {
    StyleSheet,
    Text,
    TouchableOpacity,
    View,
    Image,
    ImageBackground,
    TextInput,
    SafeAreaView,
} from 'react-native';

import AsyncStorage from '@react-native-async-storage/async-storage';

import api from '../services/api';

export default class signUp extends Component {

    render() {

        // Text Input - Don't change
        const loginTextInput = () => {
            const [number, onChangeNumber] = React.useState(null);
        }

        return (
            <View style={styles.main}>
                <View style={styles.container_header}>
                    <TouchableOpacity
                        onPress={() => this.props.navigation.navigate('First')}>
                        <View style={styles.container_header_image}>
                            <Image source={require('../assets/Back.png')} />
                        </View>
                    </TouchableOpacity>

                    <View style={styles.container_header_image}>
                        <Image source={require('../assets/pending.png')} />
                    </View>
                </View>

                <View style={styles.container_bottom}>
                    <View style={styles.contianer_bottom_image}>
                        <Image source={require('../assets/signUp.png')} />
                    </View>

                    <TextInput
                        style={styles.textinput}
                        placeholder="nome completo"
                        placeholderTextColor="rgba(200,200,200,0.5)"
                        keyboardType="default"
                        secureTextEntry={false}
                    />

                    <TextInput
                        style={styles.textinput}
                        placeholder="endereço de e-mail"
                        placeholderTextColor="rgba(200,200,200,0.5)"
                        keyboardType="default"
                        secureTextEntry={true}
                    />

                    <TextInput
                        style={styles.textinput}
                        placeholder="nome do estabelecimento"
                        placeholderTextColor="rgba(200,200,200,0.5)"
                        keyboardType="default"
                        secureTextEntry={true}
                    />

                    <TextInput
                        style={styles.textinput}
                        placeholder="celular"
                        placeholderTextColor="rgba(200,200,200,0.5)"
                        keyboardType="default"
                        secureTextEntry={true}
                    />

                    <TextInput
                        style={styles.textinput}
                        placeholder="senha"
                        placeholderTextColor="rgba(200,200,200,0.5)"
                        keyboardType="default"
                        secureTextEntry={true}
                    />

                    <TouchableOpacity
                        style={styles.btnLogin}
                        onPress={() => this.props.navigation.navigate('Main')}
                    >
                        <Text style={styles.btnLogin_text}>Entrar</Text>
                    </TouchableOpacity>

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

    textinput: {
        height: 45,
        width: 345,
        borderColor: 'white',
        borderWidth: 3,
        borderRadius: 15,
        fontSize: 18,
        paddingLeft: 10,
        marginBottom: 20,
        color: 'white',
    },

    container_bottom: {
        width: '100%',
        height: 'auto',
        alignSelf: 'center',
        alignItems: 'center',
        flex: 1,
        justifyContent: 'flex-end',
        marginBottom: 35,
    },

    contianer_bottom_image: {
        alignSelf: 'flex-start',
        height: 40,
        marginBottom: 10,
        marginLeft: 33,
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
        marginLeft: 20,
        marginRight: 20,
        height: 40,
        marginTop: 25,
    },

    btnLogin: {
        height: 55,
        width: 345,
        backgroundColor: 'white',
        alignItems: 'center',
        justifyContent: 'center',
        borderRadius: 20,
    },

    btnLogin_text: {
        fontSize: 20,
        fontWeight: 'bold',
        color: '#222222',
    }
});